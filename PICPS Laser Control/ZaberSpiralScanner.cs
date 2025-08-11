using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms.Integration;
using System.Windows.Controls;
using System.Windows.Input;
using HelixToolkit.Wpf;
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
        private HelixViewport3D viewport;

        private readonly List<Tuple<double, double, double, float>> scanData =
            new List<Tuple<double, double, double, float>>();
        private readonly Dictionary<Visual3D, Tuple<double, double, double, float>> visualToData =
            new Dictionary<Visual3D, Tuple<double, double, double, float>>();

        private readonly bool zEnabled;

        public ZaberSpiralScanner(
            Device gpib,
            double rangeXmm, double rangeYmm, double rangeZmm,
            int pointsX, int pointsY, int pointsZ,
            ElementHost helixHost, bool enableZ)
        {
            gpibDevice = gpib;
            elementHost = helixHost;
            zEnabled = enableZ;

            stepsX = pointsX;
            stepsY = pointsY;
            stepsZ = enableZ ? Math.Max(1, pointsZ) : 1;

            double centerX = ZaberController.GetPosition(2); // X
            double centerY = ZaberController.GetPosition(3); // Y
            double centerZ = ZaberController.GetPosition(1); // Z

            if (double.IsNaN(centerX) || double.IsNaN(centerY) || (enableZ && double.IsNaN(centerZ)))
                throw new InvalidOperationException("Cannot determine current probe center position.");

            startX = centerX - rangeXmm / 2.0;
            endX = centerX + rangeXmm / 2.0;
            startY = centerY - rangeYmm / 2.0;
            endY = centerY + rangeYmm / 2.0;
            startZ = enableZ ? centerZ - rangeZmm / 2.0 : centerZ;
            endZ = enableZ ? centerZ + rangeZmm / 2.0 : centerZ;

            stepX = pointsX > 1 ? rangeXmm / (pointsX - 1) : 0.0;
            stepY = pointsY > 1 ? rangeYmm / (pointsY - 1) : 0.0;
            stepZ = (enableZ && pointsZ > 1) ? rangeZmm / (pointsZ - 1) : 0.0;

            Console.WriteLine("Zaber Scanner Init");
            Console.WriteLine($"  Center: X={centerX:F4}, Y={centerY:F4}, Z={centerZ:F4}");
            Console.WriteLine($"  X: {startX:F4} → {endX:F4}  (step {stepX:F4}, {stepsX} pts)");
            Console.WriteLine($"  Y: {startY:F4} → {endY:F4}  (step {stepY:F4}, {stepsY} pts)");
            if (enableZ)
                Console.WriteLine($"  Z: {startZ:F4} → {endZ:F4}  (step {stepZ:F4}, {stepsZ} layers)");
        }

        public void Execute()
        {
            Console.WriteLine("Starting scan...");
            SetupViewport();
            JogToStart();
            ScanVolume();
            MoveToMaxPower();
            DrawPoints();
            Console.WriteLine("Scan complete.");
        }

        private void SetupViewport()
        {
            elementHost.Invoke(new Action(delegate
            {
                viewport = new HelixViewport3D();
                viewport.ShowViewCube = false;
                viewport.ShowCoordinateSystem = false;

                // Camera; ZoomExtents after drawing
                viewport.Camera = new PerspectiveCamera(
                    new Media3DPoint3D(0, 0, 200),
                    new Vector3D(0, 0, -1),
                    new Vector3D(0, 1, 0),
                    45);

                // Lights so spheres are bright
                viewport.Children.Add(new SunLight());
                viewport.Children.Add(new DefaultLights());

                // Click handler for jog-to-point
                viewport.MouseDown += Viewport_MouseDown;

                elementHost.Child = viewport;
            }));
        }

        private void Viewport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var pos = e.GetPosition(viewport);
                var hits = Viewport3DHelper.FindHits(viewport.Viewport, pos);
                if (hits == null || hits.Count == 0) return;

                for (int i = 0; i < hits.Count; i++)
                {
                    var v = hits[i].Visual as Visual3D;
                    if (v != null && visualToData.ContainsKey(v))
                    {
                        var data = visualToData[v];
                        double x = data.Item1;
                        double y = data.Item2;
                        double z = data.Item3;

                        Console.WriteLine($"[Click→Jog] X={x:F4}, Y={y:F4}, Z={z:F4}");
                        ZaberController.MoveAbsolute(2, x);
                        ZaberController.MoveAbsolute(3, y);
                        if (zEnabled) ZaberController.MoveAbsolute(1, z);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hit test/jog failed: " + ex.Message);
            }
        }

        private void JogToStart()
        {
            Console.WriteLine("Jogging to scan start position...");
            ZaberController.MoveAbsolute(2, startX);
            ZaberController.MoveAbsolute(3, startY);
            if (zEnabled) ZaberController.MoveAbsolute(1, startZ);
            Thread.Sleep(300);
        }

        private void ScanVolume()
        {
            for (int zi = 0; zi < stepsZ; zi++)
            {
                double zPos = zEnabled ? startZ + zi * stepZ : startZ;
                if (zEnabled)
                {
                    Console.WriteLine($"  Layer Z = {zPos:F4}");
                    ZaberController.MoveAbsolute(1, zPos);
                    Thread.Sleep(200);
                }

                for (int yi = 0; yi < stepsY; yi++)
                {
                    if ((yi % 2) == 0)
                    {
                        for (int xi = 0; xi < stepsX; xi++)
                            MoveAndLog(xi, yi, zPos);
                    }
                    else
                    {
                        for (int xi = stepsX - 1; xi >= 0; xi--)
                            MoveAndLog(xi, yi, zPos);
                    }
                }
            }
        }

        private void MoveAndLog(int xIndex, int yIndex, double zPos)
        {
            double x = stepsX > 1 ? startX + xIndex * stepX : startX;
            double y = stepsY > 1 ? startY + yIndex * stepY : startY;

            ZaberController.MoveAbsolute(2, x);
            ZaberController.MoveAbsolute(3, y);
            Thread.Sleep(120);

            float? power = ReadPower();
            float p = power.HasValue ? power.Value : 0f;

            if (power.HasValue)
                Console.WriteLine($"  X={x:F4}, Y={y:F4}, Z={zPos:F4}  →  {p:F3} dBm");
            else
                Console.WriteLine($"  X={x:F4}, Y={y:F4}, Z={zPos:F4}  →  (power read failed)");

            scanData.Add(Tuple.Create(x, y, zPos, p));
            PowerLogger.Log(p);
        }

        private void MoveToMaxPower()
        {
            if (scanData.Count == 0) return;

            var maxPt = scanData[0];
            for (int i = 1; i < scanData.Count; i++)
                if (scanData[i].Item4 > maxPt.Item4) maxPt = scanData[i];

            Console.WriteLine($"Move to max: X={maxPt.Item1:F4}, Y={maxPt.Item2:F4}, Z={maxPt.Item3:F4}, {maxPt.Item4:F3} dBm");
            ZaberController.MoveAbsolute(2, maxPt.Item1);
            ZaberController.MoveAbsolute(3, maxPt.Item2);
            if (zEnabled) ZaberController.MoveAbsolute(1, maxPt.Item3);
            Thread.Sleep(250);
        }

        private void DrawPoints()
        {
            elementHost.Invoke(new Action(delegate
            {
                if (viewport == null) return;

                // keep only lights
                var keep = new List<Visual3D>();
                for (int i = 0; i < viewport.Children.Count; i++)
                {
                    var v = viewport.Children[i];
                    if (v is SunLight || v is DefaultLights)
                        keep.Add(v);
                }
                viewport.Children.Clear();
                for (int i = 0; i < keep.Count; i++) viewport.Children.Add(keep[i]);

                visualToData.Clear();

                float minP = float.MaxValue, maxP = float.MinValue;
                for (int i = 0; i < scanData.Count; i++)
                {
                    float pv = scanData[i].Item4;
                    if (pv < minP) minP = pv;
                    if (pv > maxP) maxP = pv;
                }
                if (maxP - minP < 1e-6f) { minP -= 0.5f; maxP += 0.5f; }

                double baseRadius = 0.5 * Math.Max(1e-6, Math.Min(
                    stepsX > 1 ? stepX : double.MaxValue,
                    stepsY > 1 ? stepY : double.MaxValue));
                if (double.IsInfinity(baseRadius) || double.IsNaN(baseRadius)) baseRadius = 0.1;
                if (baseRadius < 0.03) baseRadius = 0.03;

                for (int i = 0; i < scanData.Count; i++)
                {
                    var pt = scanData[i];
                    double norm = Normalize(pt.Item4, minP, maxP);
                    Color c = GetGradientColor(norm);

                    var sphere = new SphereVisual3D();
                    sphere.Radius = baseRadius;                  // lattice spacing = 2*radius
                    sphere.Center = new Media3DPoint3D(pt.Item1, pt.Item2, pt.Item3);
                    sphere.Material = MaterialHelper.CreateMaterial(c, 1.0);

                    viewport.Children.Add(sphere);
                    visualToData[sphere] = pt;
                }

                // ensure lights exist
                bool hasSun = false, hasDef = false;
                for (int i = 0; i < viewport.Children.Count; i++)
                {
                    if (viewport.Children[i] is SunLight) hasSun = true;
                    if (viewport.Children[i] is DefaultLights) hasDef = true;
                }
                if (!hasSun) viewport.Children.Add(new SunLight());
                if (!hasDef) viewport.Children.Add(new DefaultLights());

                viewport.ZoomExtents();
            }));
        }

        private static double Normalize(float value, float min, float max)
        {
            if (max - min < 1e-6f) return 0.0;
            double t = (value - min) / (double)(max - min);
            if (t < 0.0) t = 0.0;
            if (t > 1.0) t = 1.0;
            return t;
        }

        private static Color GetGradientColor(double t)
        {
            if (t < 0.25) return Colors.Red;
            if (t < 0.50) return Colors.Orange;
            if (t < 0.75) return Colors.Yellow;
            if (t < 0.90) return Colors.Green;
            return Colors.Blue;
        }

        private float? ReadPower()
        {
            try
            {
                gpibDevice.Write("POD?");
                string response = gpibDevice.ReadString().Trim();
                var m = Regex.Match(response, @"[-+]?\d+\.\d+");
                if (m.Success)
                {
                    float v;
                    if (float.TryParse(m.Value, out v)) return v;
                }
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
