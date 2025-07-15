using System;
using System.IO;

namespace GPIBReaderWinForms
{
    public static class PowerLogger
    {
        private static readonly string logFilePath = "power_log.txt";

        static PowerLogger()
        {
            if (!File.Exists(logFilePath))
                File.WriteAllText(logFilePath, "Timestamp\tPower (dBm)\n");
        }

        public static void Log(float power)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\t{power:+0.000;-0.000}";
            File.AppendAllText(logFilePath, line + Environment.NewLine);
        }

        public static void EnsureExists()
        {
            if (!File.Exists(logFilePath))
                File.WriteAllText(logFilePath, "Timestamp\tPower (dBm)\n");
        }

        public static string GetPath()
        {
            return Path.GetFullPath(logFilePath);
        }
    }
}
