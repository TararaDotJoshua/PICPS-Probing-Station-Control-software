using System;
using System.Linq;
using Zaber.Motion;
using Zaber.Motion.Ascii;

namespace GPIBReaderWinForms
{
    public static class ZaberController
    {
        private static Connection connection;
        private static Device device;

        public static void Initialize(string comPort)
        {
            try
            {
                connection = Connection.OpenSerialPort(comPort);
                var devices = connection.DetectDevices();

                if (devices.Count() < 1)
                    throw new Exception("No Zaber devices found.");

                device = devices[0]; // Single controller with 3 axes

                Console.WriteLine("Zaber initialized successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Zaber init error: " + ex.Message);
            }
        }

        public static void MoveRelative(int axisNumber, double distanceMm)
        {
            if (device == null) return;
            if (axisNumber < 1 || axisNumber > 3) return;

            var axis = device.GetAxis(axisNumber);
            axis?.MoveRelative(distanceMm, Units.Length_Millimetres);
        }

        public static void MoveAbsolute(int axisNumber, double positionMm)
        {
            if (device == null) return;
            if (axisNumber < 1 || axisNumber > 3) return;

            var axis = device.GetAxis(axisNumber);
            axis?.MoveAbsolute(positionMm, Units.Length_Millimetres);
        }

        public static double GetPosition(int axisNumber)
        {
            if (device == null || axisNumber < 1 || axisNumber > 3)
                return double.NaN;

            var axis = device.GetAxis(axisNumber);
            return axis?.GetPosition(Units.Length_Millimetres) ?? double.NaN;
        }
        public static void HomeAll()
        {
            if (device != null)
            {
                Console.WriteLine("Homing all axes...");

                for (int i = 1; i <= 3; i++)
                {
                    var axis = device.GetAxis(i);
                    axis.Home(); // Start homing
                }

                // Wait for all axes to complete homing
                bool anyBusy;
                do
                {
                    anyBusy = false;
                    for (int i = 1; i <= 3; i++)
                    {
                        var axis = device.GetAxis(i);
                        if (axis.IsBusy())
                        {
                            anyBusy = true;
                            break;
                        }
                    }
                    System.Threading.Thread.Sleep(100); // Small delay before rechecking
                } while (anyBusy);

                Console.WriteLine("All axes homed.");
            }
            else
            {
                Console.WriteLine("Device not initialized.");
            }
        }



    }
}
