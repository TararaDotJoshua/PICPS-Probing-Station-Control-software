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
            ZaberController.Initialize("COM3");

        }

        private void InitializeGPIB()
        {
            try
            {
                device = new Device(0, 25, 0);
                device.Write("C 2");   // Select Slot 2
                device.Write("D 1");   // Select Input 1 (Device A)
                device.Write("PF B");  // Set dBm output
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing GPIB device: " + ex.Message);
            }
        }

        private void InitializeTimer()
        {
            readTimer = new System.Windows.Forms.Timer
            {
                Interval = 5 // 0.005 seconds
            };
            readTimer.Tick += ReadTimer_Tick;
        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                device.Write("POD?");
                string response = device.ReadString().Trim();
                var match = Regex.Match(response, @"[-+]?\d+\.\d+");

                if (match.Success && float.TryParse(match.Value, out float power))
                {
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
            try
            {
                device.Write(":OUTPut3:CHANnel3:STATE ON"); // Turn Channel 3 laser ON
                readTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start laser: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                readTimer.Stop();
                device.Write(":OUTPut3:CHANnel3:STATE OFF"); // Turn Channel 3 laser OFF
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to stop laser: " + ex.Message);
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // X-Left
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(2, -step);
        }

        private void button2_Click(object sender, EventArgs e) // X-Right
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(2, step);
        }

        private void button6_Click(object sender, EventArgs e) // Y-Up
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(3, step);
        }

        private void button5_Click(object sender, EventArgs e) // Y-Down
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(3, -step);
        }

        private void button4_Click(object sender, EventArgs e) // Z-Out
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(1, -step);
        }

        private void button3_Click(object sender, EventArgs e) // Z-In
        {
            if (double.TryParse(textBox1.Text, out double step))
                ZaberController.MoveRelative(1, step);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void HomeAll_Click(object sender, EventArgs e)
        {
            ZaberController.HomeAll();
        }
        private void button4_Click_1(object sender, EventArgs e) // Z-Out
        {
        
        }
    }
}
