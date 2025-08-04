using System;
using System.Text.RegularExpressions;
using System.Threading;
using NationalInstruments.NI4882;

namespace GPIBReaderWinForms
{
    public class ZaberSpiralScanner
    {
        private readonly Device gpibDevice;
        private readonly int stepsX, stepsY;
        private readonly double startX, endX, startY, endY;
        private readonly double stepX, stepY;

        public ZaberSpiralScanner(Device gpib, double rangeXmm, double rangeYmm, int pointsX, int pointsY)
        {
            gpibDevice = gpib;
            stepsX = pointsX;
            stepsY = pointsY;

            startX = -rangeXmm / 2.0;
            endX = rangeXmm / 2.0;
            startY = -rangeYmm / 2.0;
            endY = rangeYmm / 2.0;

            stepX = rangeXmm / (pointsX - 1);
            stepY = rangeYmm / (pointsY - 1);
        }

        public void Execute()
        {
            JogToCenter();
            CheckEdges();
            SpiralScan();
        }

        private void JogToCenter()
        {
            double centerX = (startX + endX) / 2.0;
            double centerY = (startY + endY) / 2.0;

            ZaberController.MoveAbsolute(1, centerX); // X
            ZaberController.MoveAbsolute(2, centerY); // Y
            Thread.Sleep(500);
        }

        private void CheckEdges()
        {
            (double x, double y)[] corners =
            {
                (startX, startY),
                (endX, startY),
                (endX, endY),
                (startX, endY)
            };

            foreach (var (x, y) in corners)
            {
                ZaberController.MoveAbsolute(1, x);
                ZaberController.MoveAbsolute(2, y);
                Thread.Sleep(200);
            }

            JogToCenter();
        }

        private void SpiralScan()
        {
            int left = 0, right = stepsX - 1;
            int top = 0, bottom = stepsY - 1;

            while (left <= right && top <= bottom)
            {
                for (int x = left; x <= right; x++)
                    MoveAndLog(top, x);
                top++;

                for (int y = top; y <= bottom; y++)
                    MoveAndLog(y, right);
                right--;

                if (top <= bottom)
                {
                    for (int x = right; x >= left; x--)
                        MoveAndLog(bottom, x);
                    bottom--;
                }

                if (left <= right)
                {
                    for (int y = bottom; y >= top; y--)
                        MoveAndLog(y, left);
                    left++;
                }
            }
        }

        private void MoveAndLog(int yIndex, int xIndex)
        {
            double x = startX + xIndex * stepX;
            double y = startY + yIndex * stepY;

            ZaberController.MoveAbsolute(1, x); // X
            ZaberController.MoveAbsolute(2, y); // Y
            Thread.Sleep(150);

            float? power = ReadPower();
            if (power.HasValue)
                PowerLogger.Log(power.Value);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Power read error: " + ex.Message);
            }

            return null;
        }
    }
}
