using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
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
        private readonly int stepsX, stepsY, stepsZ;
        private readonly double startX, endX, startY, endY, startZ, endZ;
        private readonly double stepX, stepY, stepZ;
        private readonly ElementHost elementHost;
        private readonly List<Tuple<double, double, double, float>> scanData = new List<Tuple<double, double, double, float>>();
        private readonly bool zEnabled;

        public ZaberSpiralScanner(Device gpib, double rangeXmm, double rangeYmm, double rangeZmm,
                                  int pointsX, int pointsY, int pointsZ,
                                  ElementHost helixHost, bool enableZ)
        {
            gpibDevice = gpib;
            elementHost = helixHost;
            zEnabled = enableZ;

            stepsX = pointsX;
            stepsY = pointsY;
            stepsZ = enableZ ? pointsZ : 1;

            double centerX = ZaberController.GetPosition(2);
            double centerY = ZaberController.GetPosition(3);
            double centerZ = ZaberController.GetPosition(1);

            if (double.IsNaN(centerX) || double.IsNaN(centerY) || (enableZ && double.IsNaN(centerZ)))
                throw new InvalidOperationException("❌ Cannot determine current probe center position.");

            startX = centerX - rangeXmm / 2.0;
            endX = centerX + rangeXmm / 2.0;
            startY = centerY - rangeYmm / 2.0;
            endY = centerY + rangeYmm / 2.0;
            startZ = enableZ ? centerZ - rangeZmm / 2.0 : centerZ;
            endZ = enableZ ? centerZ + rangeZmm / 2.0 : centerZ;

            stepX = rangeXmm / (pointsX - 1);
            stepY = rangeYmm / (pointsY - 1);
            stepZ = enableZ ? rangeZmm / (pointsZ - 1) : 0;

            Console.WriteLine($"Zaber Scanner Init (Z enabled: {enableZ})");
            Console.WriteLine($"Center: X={centerX:F2}, Y={centerY:F2}, Z={centerZ:F2}");
            Console.WriteLine($"X range: {startX:F2} → {endX:F2}, step: {stepX:F2} mm");
            Console.WriteLine($"Y range: {startY:F2} → {endY:F2}, step: {stepY:F2} mm");
            if (enableZ)
                Console.WriteLine($"Z range: {startZ:F2} → {endZ:F2}, step: {stepZ:F2} mm");
        }

        public void Execute()
        {
            Console.WriteLine("Starting scan...");
            JogToStart();
            ScanVolume();
            MoveToMaxPower();
            UpdateHelix3D();
            Console.WriteLine("Scan complete.");
        }

        private void JogToStart()
        {
            Console.WriteLine("Jogging to scan start position...");
            ZaberController.MoveAbsolute(2, startX); // X
            ZaberController.MoveAbsolute(3, startY); // Y
            if (zEnabled)
                ZaberController.MoveAbsolute(1, startZ); // Z
            Thread.Sleep(500);
        }

        private void ScanVolume()
        {
            for (int z = 0; z < stepsZ; z++)
            {
                double zPos = zEnabled ? startZ + z * stepZ : startZ;
                if (zEnabled)
                {
                    Console.WriteLine($"→ Z = {zPos:F2} mm");
                    ZaberController.MoveAbsolute(1, zPos);
                    Thread.Sleep(300);
                }

                for (int y = 0; y < stepsY; y++)
                {
                    if (y % 2 == 0)
                    {
                        for (int x = 0; x < stepsX; x++)
                            MoveAndLog(x, y, zPos);
                    }
                    else
                    {
                        for (int x = stepsX - 1; x >= 0; x--)
                            MoveAndLog(x, y, zPos);
                    }
                }
            }
        }

        private void MoveAndLog(int xIndex, int yIndex, double zPos)
        {
            double x = startX + xIndex * stepX;
            double y = startY + yIndex * stepY;

            ZaberController.MoveAbsolute(2, x);
            ZaberController.MoveAbsolute(3, y);
            Thread.Sleep(150);

            float? power = ReadPower();
            if (power.HasValue)
            {
                Console.WriteLine($"X={x:F2} Y={y:F2} Z={zPos:F2} → Power={power.Value:F2} dBm");
                scanData.Add(Tuple.Create(x, y, zPos, power.Value));
                PowerLogger.Log(power.Value);
            }
            else
            {
                Console.WriteLine("    Power read failed.");
                scanData.Add(Tuple.Create(x, y, zPos, 0f));
            }
        }

        private void MoveToMaxPower()
        {
            if (scanData.Count == 0) return;

            var maxPoint = scanData[0];
            foreach (var pt in scanData)
                if (pt.Item4 > maxPoint.Item4) maxPoint = pt;

            Console.WriteLine($"Moving to max power point: X={maxPoint.Item1:F2}, Y={maxPoint.Item2:F2}, Z={maxPoint.Item3:F2}, Power={maxPoint.Item4:F2} dBm");
            ZaberController.MoveAbsolute(2, maxPoint.Item1);
            ZaberController.MoveAbsolute(3, maxPoint.Item2);
            if (zEnabled)
                ZaberController.MoveAbsolute(1, maxPoint.Item3);
            Thread.Sleep(500);
        }

        private void UpdateHelix3D()
        {
            elementHost.Invoke(new Action(delegate
            {
                HelixViewport3D viewport = new HelixViewport3D();
                viewport.Camera = new PerspectiveCamera(new Media3DPoint3D(0, 0, 100), new Vector3D(0, 0, -1), new Vector3D(0, 1, 0), 45);
                viewport.Children.Add(new SunLight());

                float minPower = float.MaxValue, maxPower = float.MinValue;
                foreach (var pt in scanData)
                {
                    if (pt.Item4 < minPower) minPower = pt.Item4;
                    if (pt.Item4 > maxPower) maxPower = pt.Item4;
                }

                foreach (var pt in scanData)
                {
                    double norm = Normalize(pt.Item4, minPower, maxPower);
                    Color color = GetGradientColor(norm);

                    SphereVisual3D sphere = new SphereVisual3D();
                    sphere.Radius = stepX / 2;
                    sphere.Center = new Media3DPoint3D(pt.Item1, pt.Item2, pt.Item3);
                    sphere.Material = MaterialHelper.CreateMaterial(color);
                    viewport.Children.Add(sphere);
                }

                viewport.ZoomExtents();
                elementHost.Child = viewport;
            }));
        }

        private double Normalize(float val, float min, float max)
        {
            if (max - min < 1e-6) return 0;
            double norm = (val - min) / (max - min);
            if (norm < 0) return 0;
            if (norm > 1) return 1;
            return norm;
        }

        private Color GetGradientColor(double t)
        {
            if (t < 0.25) return Colors.Red;
            else if (t < 0.5) return Colors.Orange;
            else if (t < 0.75) return Colors.Yellow;
            else if (t < 0.9) return Colors.Green;
            return Colors.Blue;
        }

        private float? ReadPower()
        {
            try
            {
                gpibDevice.Write("POD?");
                string response = gpibDevice.ReadString().Trim();
                Match match = Regex.Match(response, @"[-+]?\d+\.\d+");
                if (match.Success && float.TryParse(match.Value, out float power))
                    return power;
                Console.WriteLine("    GPIB: invalid response.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("    GPIB read error: " + ex.Message);
            }
            return null;
        }
    }
}
