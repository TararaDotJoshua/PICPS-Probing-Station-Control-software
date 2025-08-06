using GPIBReaderWinForms;
using HelixToolkit.Wpf;
using NationalInstruments.NI4882;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.GenericMotorCLI.AdvancedMotor;
using Thorlabs.MotionControl.GenericMotorCLI.ControlParameters;
using Thorlabs.MotionControl.GenericMotorCLI.KCubeMotor;
using Thorlabs.MotionControl.GenericMotorCLI.Settings;
using Thorlabs.MotionControl.KCube.StepperMotorCLI;

namespace GPIBReaderWinForms
{
    public partial class MainForm : Form
    {
        private Device device;
        private System.Windows.Forms.Timer readTimer;

        private KCubeStepper xMotor;
        private KCubeStepper yMotor;
        private KCubeStepper zMotor;

        public MainForm()
        {
            InitializeComponent();
            InitializeGPIB();
            InitializeTimer();
            ZaberController.Initialize("COM3");
            InitializeMotors();
        }

        private void InitializeMotors()
        {
            try
            {
                DeviceManagerCLI.BuildDeviceList();

                xMotor = InitializeMotor("26004430");
                yMotor = InitializeMotor("26004427");
                zMotor = InitializeMotor("26004431");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing KST motors: " + ex.Message);
            }
        }

        private KCubeStepper InitializeMotor(string serial)
        {
            KCubeStepper device = KCubeStepper.CreateKCubeStepper(serial);
            device.Connect(serial);
            if (!device.IsSettingsInitialized())
                device.WaitForSettingsInitialized(5000);

            device.StartPolling(250);
            Thread.Sleep(500);
            device.EnableDevice();
            Thread.Sleep(500);

            MotorConfiguration config = device.LoadMotorConfiguration(serial);
            KCubeStepperMotorSettings settings = device.MotorDeviceSettings as KCubeStepperMotorSettings;

            return device;
        }

        private void HomeAll_Click(object sender, EventArgs e)
        {
            ZaberController.HomeAll();
            HomeDevice(zMotor);
            HomeDevice(xMotor);
            HomeDevice(yMotor);
        }

        private void HomeDevice(IGenericAdvancedMotor device)
        {
            try
            {
                Console.WriteLine($"Homing device {device.GetDeviceInfo().SerialNumber}");
                device.Home(60000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to home device: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e) => MoveRelative(zMotor, +1);
        private void button7_Click(object sender, EventArgs e) => MoveRelative(zMotor, -1);
        private void button10_Click(object sender, EventArgs e) => MoveRelative(xMotor, +1);
        private void button9_Click(object sender, EventArgs e) => MoveRelative(xMotor, -1);
        private void button12_Click(object sender, EventArgs e) => MoveRelative(yMotor, +1);
        private void button11_Click(object sender, EventArgs e) => MoveRelative(yMotor, -1);

        private void MoveRelative(KCubeStepper motor, int direction)
        {
            if (decimal.TryParse(textBox1.Text, out decimal mm))
            {
                decimal current = motor.Position;
                decimal target = current + direction * mm;

                Console.WriteLine($"[{motor.GetDeviceInfo().SerialNumber}] Current: {current}, Target: {target}, Homed: {motor.Status.IsHomed}");

                if (!motor.Status.IsHomed)
                {
                    MessageBox.Show("Motor not homed!");
                    return;
                }

                try
                {
                    motor.MoveTo(target, 60000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to move relative: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid step size.");
            }
        }

        private void InitializeGPIB()
        {
            try
            {
                device = new Device(0, 25, 0);
                device.Write("C 2");
                device.Write("D 1");
                device.Write("PF B");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing GPIB device: " + ex.Message);
            }
        }

        private void InitializeTimer()
        {
            readTimer = new System.Windows.Forms.Timer { Interval = 5 };
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
                MessageBox.Show("Unable to open log: " + ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) => ZaberController.MoveRelative(2, -GetStep());
        private void button2_Click(object sender, EventArgs e) => ZaberController.MoveRelative(2, GetStep());
        private void button6_Click(object sender, EventArgs e) => ZaberController.MoveRelative(3, GetStep());
        private void button5_Click(object sender, EventArgs e) => ZaberController.MoveRelative(3, -GetStep());
        private void button4_Click(object sender, EventArgs e) => ZaberController.MoveRelative(1, -GetStep());
        private void button3_Click(object sender, EventArgs e) => ZaberController.MoveRelative(1, GetStep());

        private double GetStep()
        {
            if (double.TryParse(textBox1.Text, out double step))
                return step;
            MessageBox.Show("Invalid step size.");
            return 0;
        }

        private void button4_Click_1(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            xMotor?.StopPolling();
            xMotor?.Disconnect(false);

            yMotor?.StopPolling();
            yMotor?.Disconnect(false);

            zMotor?.StopPolling();
            zMotor?.Disconnect(false);
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void RunScan_Click(object sender, EventArgs e)
        {
            double.TryParse(ZSize.Text, out double rangeZ);
            int.TryParse(ZDataPoints.Text, out int pointsZ);
            bool zEnabled = rangeZ > 0 && pointsZ > 0;

            if (!double.TryParse(XSize.Text, out double rangeX) ||
                            !double.TryParse(YSize.Text, out double rangeY) ||
                            !int.TryParse(XDataPoints.Text, out int pointsX) ||
                            !int.TryParse(YDataPoints.Text, out int pointsY))
            {
                MessageBox.Show("Invalid scan parameters.");
                return;
            }

            var scanner = new ZaberSpiralScanner(device, rangeX, rangeY, zEnabled ? rangeZ : 0, pointsX, pointsY, zEnabled ? pointsZ : 0, elementHostHelix, zEnabled);
            scanner.Execute();
            MessageBox.Show("Zaber scan complete. Power values logged.");
        }

        private void RunScan_Click_1(object sender, EventArgs e)
        {
            RunScan_Click(sender, e);
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e) { }

        private async void label2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    ZaberController.HomeAxis(1);
                    ZaberController.HomeAxis(2);
                    ZaberController.HomeAxis(3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Zaber homing failed: {ex.Message}");
                }
            });
        }

        private async void label3_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    xMotor.Home(60000);
                    yMotor.Home(60000);
                    zMotor.Home(60000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thorlabs homing failed: {ex.Message}");
                }
            });
        }

        private void JogToHigh_Click(object sender, EventArgs e)
        {

        }

        private void btnFitToScreen_Click(object sender, EventArgs e)
        {
            if (elementHostHelix?.Child is HelixViewport3D viewport)
            {
                viewport.ZoomExtents();
                Console.WriteLine("Fit to screen triggered.");
            }
            else
            {
                Console.WriteLine("No Helix viewport found.");
            }
        }

        private void ZLayers_Scroll(object sender, EventArgs e)
        {

        }
    }
}
