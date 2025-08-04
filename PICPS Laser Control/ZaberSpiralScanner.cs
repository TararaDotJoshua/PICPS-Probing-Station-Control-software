using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Threading;
using System.Windows.Forms.Integration;
using HelixToolkit.Wpf;
using System.Windows.Controls;
using Media3DPoint3D = System.Windows.Media.Media3D.Point3D;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using NationalInstruments.NI4882;

namespace GPIBReaderWinForms
{
    public class ZaberSpiralScanner
    {
        private readonly Device gpibDevice;
        private readonly int stepsX, stepsY;
        private readonly double startX, endX, startY, endY;
        private readonly double stepX, stepY;
        private readonly ElementHost elementHost;
        private readonly List<(double x, double y, float power)> scanData = new List<(double, double, float)>();

        public ZaberSpiralScanner(Device gpib, double rangeXmm, double rangeYmm, int pointsX, int pointsY, ElementHost helixHost)
        {
            gpibDevice = gpib;
            stepsX = pointsX;
            stepsY = pointsY;
            elementHost = helixHost;

            startX = -rangeXmm / 2.0;
            endX = rangeXmm / 2.0;
            startY = -rangeYmm / 2.0;
            endY = rangeYmm / 2.0;

            stepX = rangeXmm / (pointsX - 1);
            stepY = rangeYmm / (pointsY - 1);

            Console.WriteLine($"Scanner initialized with {stepsX} x {stepsY} points.");
            Console.WriteLine($"X range: {startX} to {endX} mm, StepX: {stepX} mm");
            Console.WriteLine($"Y range: {startY} to {endY} mm, StepY: {stepY} mm");
        }

        public void Execute()
        {
            Console.WriteLine("Starting raster scan...");
            JogToTopLeft();
            RasterScan();
            MoveToMaxPower();
            JogToCenter();
            UpdateHelix3D();
            Console.WriteLine("Raster scan completed.");
        }

        private void JogToTopLeft()
        {
            double x = startX;
            double y = startY;
            Console.WriteLine($"Jogging to top-left: ({x}, {y}) mm");
            ZaberController.MoveAbsolute(2, x);
            ZaberController.MoveAbsolute(3, y);
            Thread.Sleep(500);
        }

        private void JogToCenter()
        {
            double centerX = (startX + endX) / 2.0;
            double centerY = (startY + endY) / 2.0;
            Console.WriteLine($"Jogging to center: ({centerX}, {centerY}) mm");
            ZaberController.MoveAbsolute(2, centerX);
            ZaberController.MoveAbsolute(3, centerY);
            Thread.Sleep(500);
        }

        private void RasterScan()
        {
            for (int y = 0; y < stepsY; y++)
            {
                if (y % 2 == 0)
                {
                    for (int x = 0; x < stepsX; x++)
                        MoveAndLog(y, x);
                }
                else
                {
                    for (int x = stepsX - 1; x >= 0; x--)
                        MoveAndLog(y, x);
                }
            }
        }

        private void MoveAndLog(int yIndex, int xIndex)
        {
            double x = startX + xIndex * stepX;
            double y = startY + yIndex * stepY;

            Console.WriteLine($"Moving to: X={x:F3} mm, Y={y:F3} mm");
            ZaberController.MoveAbsolute(2, x);
            ZaberController.MoveAbsolute(3, y);
            Thread.Sleep(150);

            float? power = ReadPower();
            if (power.HasValue)
            {
                Console.WriteLine($"    dBm: {power.Value:F3}");
                PowerLogger.Log(power.Value);
                scanData.Add((x, y, power.Value));
            }
            else
            {
                Console.WriteLine("    Power read failed.");
                scanData.Add((x, y, 0));
            }
        }

        private void MoveToMaxPower()
        {
            if (scanData.Count == 0) return;
            var maxPoint = scanData[0];
            foreach (var point in scanData)
            {
                if (point.power > maxPoint.power)
                    maxPoint = point;
            }
            Console.WriteLine($"Moving to max power location: X={maxPoint.x:F3}, Y={maxPoint.y:F3}, Power={maxPoint.power:F3} dBm");
            ZaberController.MoveAbsolute(2, maxPoint.x);
            ZaberController.MoveAbsolute(3, maxPoint.y);
            Thread.Sleep(500);
        }

        private void UpdateHelix3D()
        {
            elementHost.Invoke(new Action(() =>
            {
                var viewport = new HelixViewport3D();
                viewport.Camera = new PerspectiveCamera(new Media3DPoint3D(0, 0, 100), new Vector3D(0, 0, -1), new Vector3D(0, 1, 0), 45);
                viewport.Children.Add(new SunLight());

                float minPower = float.MaxValue;
                float maxPower = float.MinValue;
                foreach (var (_, _, power) in scanData)
                {
                    if (power < minPower) minPower = power;
                    if (power > maxPower) maxPower = power;
                }

                foreach (var (x, y, power) in scanData)
                {
                    double normalized = (power - minPower) / (maxPower - minPower + 0.0001);
                    Color color = GetGradientColor(normalized);

                    var sphere = new SphereVisual3D
                    {
                        Radius = 0.5,
                        Center = new Media3DPoint3D(x, y, power),
                        Material = MaterialHelper.CreateMaterial(color)
                    };
                    viewport.Children.Add(sphere);
                }

                var bounds = Rect3D.Empty;
                foreach (var (x, y, z) in scanData)
                    bounds.Union(new Rect3D(x, y, z, 0, 0, 0));

                viewport.ZoomExtents(bounds);
                elementHost.Child = viewport;
            }));
        }

        private Color GetGradientColor(double t)
        {
            if (t < 0.25)
                return Colors.Red;
            else if (t < 0.5)
                return Colors.Orange;
            else if (t < 0.75)
                return Colors.Yellow;
            else if (t < 0.9)
                return Colors.Green;
            else
                return Colors.Blue;
        }

        private float? ReadPower()
        {
            try
            {
                gpibDevice.Write("POD?");
                string response = gpibDevice.ReadString().Trim();
                var match = Regex.Match(response, @"[-+]?\d+\.\d+");
                if (match.Success && float.TryParse(match.Value, out float power))
                    return power;
                Console.WriteLine("    GPIB read: invalid response.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("    GPIB read error: " + ex.Message);
            }

            return null;
        }
    }
}
