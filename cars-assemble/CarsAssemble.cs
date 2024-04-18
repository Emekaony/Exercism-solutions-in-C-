using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.00,
            1 or 2 or 3 or 4 => 1.00,
            5 or 6 or 7 or 8 => 0.90,
            9 => 0.80,
            10 => 0.77,
            _ => 0.00,
        };
    }

    public static double ProductionRatePerHour(int speed)
    {
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
