using System;
using System.Collections.Generic;
using System.Threading;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.KCube.DCServoCLI;

public static class KCubeController
{
    private static Dictionary<string, KCubeDCServo> devices = new Dictionary<string, KCubeDCServo>();

    public static void Initialize()
    {
        DeviceManagerCLI.BuildDeviceList();
        List<string> serialNumbers = DeviceManagerCLI.GetDeviceList(KCubeDCServo.DevicePrefix);

        foreach (string serial in serialNumbers)
        {
            KCubeDCServo device = KCubeDCServo.CreateKCubeDCServo(serial);
            device.Connect(serial);
            device.WaitForSettingsInitialized(5000);
            device.StartPolling(250);
            device.EnableDevice();
            device.Home(60000);
            devices[serial] = device;
        }
    }

    public static void MoveRelative(string serial, decimal mm)
    {
        KCubeDCServo device;
        if (devices.TryGetValue(serial, out device))
        {
            device.MoveRelative((MotorDirection.Forward), (decimal)(double)mm, 1000);
        }
    }

    public static void MoveAbsolute(string serial, decimal mm)
    {
        KCubeDCServo device;
        if (devices.TryGetValue(serial, out device))
        {
            device.SetMoveAbsolutePosition(mm); // Set the target position
            device.MoveAbsolute(1000); // Execute the move with timeout
        }
    }

    public static void Home(string serial)
    {
        KCubeDCServo device;
        if (devices.TryGetValue(serial, out device))
        {
            device.Home(60000);
        }
    }

    public static double GetPosition(string serial)
    {
        KCubeDCServo device;
        if (devices.TryGetValue(serial, out device))
        {
            return (double)device.Position;
        }
        return double.NaN;
    }

    public static void Stop(string serial)
    {
        KCubeDCServo device;
        if (devices.TryGetValue(serial, out device))
        {
            device.Stop(1000);
        }
    }
}