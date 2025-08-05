using System;
using System.IO.Ports;
using System.Threading;

namespace GPIBReaderWinForms
{
    public static class ZaberController
    {
        private static SerialPort port;
        private const int StepsPerMm = 64000;

        public static void Initialize(string comPort)
        {
            try
            {
                port = new SerialPort(comPort, 115200, Parity.None, 8, StopBits.One);
                port.NewLine = "\r\n";
                port.ReadTimeout = 1000;
                port.WriteTimeout = 1000;
                port.Open();

                // Disable checksum
                SendCommand("/0 set comm.checksum 0");
                Thread.Sleep(50);

                // Confirm communication
                string response = SendCommand("/1 get pos");
                Console.WriteLine("Zaber initialized.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Zaber init error: " + ex.Message);
            }
        }

        public static void MoveRelative(int axis, double distanceMm)
        {
            if (!IsPortOpen()) return;

            int microsteps = (int)(distanceMm * StepsPerMm);
            string command = $"/1 {axis} move rel {microsteps}";
            SendCommand(command);
        }

        public static void MoveAbsolute(int axis, double positionMm)
        {
            if (!IsPortOpen()) return;

            int microsteps = (int)(positionMm * StepsPerMm);
            string command = $"/1 {axis} move abs {microsteps}";
            SendCommand(command);
        }

        public static double GetPosition(int axis)
        {
            if (!IsPortOpen()) return double.NaN;

            string response = SendCommand($"/1 {axis} get pos");
            if (response == null) return double.NaN;

            string[] parts = response.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 6)
            {
                int pos;
                if (int.TryParse(parts[5], out pos))
                {
                    double mm = pos / (double)StepsPerMm;
                    Console.WriteLine($"Axis {axis} position: {mm:F3} mm");
                    return mm;
                }
            }

            Console.WriteLine("Failed to parse position.");
            return double.NaN;
        }

        public static void HomeAll()
        {
            if (!IsPortOpen()) return;

            Console.WriteLine("Homing all axes...");
            for (int i = 1; i <= 3; i++)
            {
                SendCommand($"/1 {i} home");
                Thread.Sleep(50);
            }

            Thread.Sleep(5000);
            Console.WriteLine("All axes homed.");
        }

        public static void HomeAxis(int axis)
        {
            if (port != null && port.IsOpen)
            {
                port.WriteLine($"/1 {axis} home");
                Thread.Sleep(200); // Allow buffer time
                WaitUntilIdle(axis);
            }
        }

        private static void WaitUntilIdle(int axis)
        {
            string response = "";
            do
            {
                port.WriteLine($"/1 {axis} get pos");
                response = port.ReadLine();
            }
            while (!response.Contains("IDLE") && !response.Contains("OK")); // crude idle check
        }

        private static string SendCommand(string command)
        {
            try
            {
                port.DiscardInBuffer();
                port.WriteLine(command);
                Console.WriteLine($"Sent: {command}");

                string response = port.ReadLine();
                Console.WriteLine($"Recv: {response}");

                // If the command was a motion command, query and print position
                if (command.Contains("move"))
                {
                    for (int axis = 2; axis <= 3; axis++)
                    {
                        double pos = GetPosition(axis);
                        Console.WriteLine($"  Axis {axis} pos: {pos:F3} mm");
                    }
                }

                return response;
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Timeout waiting for response.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serial error: " + ex.Message);
                return null;
            }
        }


        private static bool IsPortOpen()
        {
            if (port == null || !port.IsOpen)
            {
                Console.WriteLine("Zaber serial port is not open.");
                return false;
            }
            return true;
        }
    }
}
