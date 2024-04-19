using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    public int totalDistanceDriven = 0;
    public int batteryLevel = 100;

    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public int Speed
    {
        get => _speed;
    }

    public bool BatteryDrained()
    {
        return batteryLevel < _batteryDrain;
    }

    public int DistanceDriven()
    {
        return totalDistanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            totalDistanceDriven += _speed; // increase distance driven by the speed of the car
            batteryLevel -= _batteryDrain; // decrement the battery level by the battery drain
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int _distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int distanceToDrive = _distance;
        bool canFinish = true;
        while (distanceToDrive > 0)
        {
            if (car.BatteryDrained())
            {
                canFinish = false;
                break;
            }
            car.Drive();
            distanceToDrive -= car.Speed;

        }
        return canFinish;
    }
}
