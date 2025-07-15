using System;
using System.Windows.Forms;
using NationalInstruments.NI4882;
using System.Text.RegularExpressions;

namespace GPIBReaderWinForms
{
    public partial class MainForm : Form
    {
        private Device device;
        private System.Windows.Forms.Timer readTimer;

        public MainForm()
        {
            InitializeComponent();
            InitializeGPIB();
            InitializeTimer();
        }

        private void InitializeGPIB()
        {
            try
            {
                device = new Device(0, 25, 0);
                device.Write("C 2");  // Select Slot 2
                device.Write("D 1");  // Select Input 1 (Device A)
                device.Write("PF B"); // Set dBm output
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing GPIB device: " + ex.Message);
            }
        }

        private void InitializeTimer()
        {
            readTimer = new System.Windows.Forms.Timer();
            readTimer.Interval = 250; // 0.25 seconds
            readTimer.Tick += ReadTimer_Tick;
        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                device.Write("POD?");
                string response = device.ReadString().Trim();
                Match match = Regex.Match(response, @"[-+]?\d+\.\d+");

                if (match.Success)
                {
                    float power = float.Parse(match.Value);
                    lblPower.Text = $"{power:+0.000;-0.000} dBm";
                    PowerLogger.Log(power);
                }
                else
                {
                    lblPower.Text = "Invalid response";
                }
            }
            catch (Exception ex)
            {
                lblPower.Text = "Error reading: " + ex.Message;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            readTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            try
            {
                PowerLogger.EnsureExists();
                System.Diagnostics.Process.Start("notepad.exe", PowerLogger.GetPath());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open log: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
