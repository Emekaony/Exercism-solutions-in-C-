

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesSpent)
    {
        return new Lasagna().ExpectedMinutesInOven() - minutesSpent;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        const int minutePerLayer = 2;
        return minutePerLayer * numberOfLayers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
    {
        return new Lasagna().PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
    }
}
