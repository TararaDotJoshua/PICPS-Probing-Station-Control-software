using System;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.KCube.StepperMotorCLI;
using Thorlabs.MotionControl.KCube.StepperMotorCLI.Native;
public static class KCubeController
{
    public static void Home(string serial)
    {
        try
        {
            DeviceManagerCLI.BuildDeviceList();

            using (KCubeStepper device = KCubeStepper.CreateKCubeStepper(serial))
            {
                device.Connect(serial);
                if (!device.IsSettingsInitialized())
                    device.WaitForSettingsInitialized(5000);

                device.StartPolling(250);
                System.Threading.Thread.Sleep(500);
                device.EnableDevice();
                System.Threading.Thread.Sleep(500);

                var config = device.LoadMotorConfiguration(serial);
                Console.WriteLine($"Homing {serial} ({config.DeviceSettingsName})...");
                device.Home(60000);
                System.Threading.Thread.Sleep(2000);


                device.StopPolling();
                device.Disconnect(true);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error homing {serial}: {ex.Message}");
        }
    }

    public static void MoveRelative(string serial, decimal distance_mm)
    {
        try
        {
            using (KCubeStepper device = KCubeStepper.CreateKCubeStepper(serial))
            {
                device.Connect(serial);
                if (!device.IsSettingsInitialized())
                    device.WaitForSettingsInitialized(5000);

                device.StartPolling(250);
                System.Threading.Thread.Sleep(500);
                device.EnableDevice();
                System.Threading.Thread.Sleep(500);

                var config = device.LoadMotorConfiguration(serial);

                // Convert mm to device units (assuming 64000 steps/mm)
                int stepDistance = (int)(distance_mm * 64000);
                device.MoveRelative(stepDistance); 
                System.Threading.Thread.Sleep(2000);


                device.StopPolling();
                device.Disconnect(true);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error moving {serial}: {ex.Message}");
        }
    }
}
