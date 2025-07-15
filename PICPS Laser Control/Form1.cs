
using System;
using System.Windows.Forms;
using NationalInstruments.NI4882;
using System.Threading;

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
            readTimer.Interval = 25; // .025 seconds
            readTimer.Tick += ReadTimer_Tick;
        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                device.Write("POD?");
                string response = device.ReadString().Trim();
                var match = System.Text.RegularExpressions.Regex.Match(response, @"[-+]?\d+\.\d+");
                lblPower.Text = match.Success ? $"{match.Value} dBm" : "Invalid response";


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

        private void lblPower_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
