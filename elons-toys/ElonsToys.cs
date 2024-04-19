using System;

class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceCovered = 0;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceCovered} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage == 0 ? "Battery empty" : $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (_batteryPercentage == 0)
        {
            Console.WriteLine("Unable to drive with battery below 0%");
        }
        else
        {
            _batteryPercentage--;
            _distanceCovered += 20;
        }
    }
}
