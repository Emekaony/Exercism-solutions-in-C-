class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceCovered = 0;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {_distanceCovered} meters";

    public string BatteryDisplay() => _batteryPercentage == 0 ? "Battery empty" : $"Battery at {_batteryPercentage}%";

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _batteryPercentage--;
            _distanceCovered += 20;
        }
    }
}
