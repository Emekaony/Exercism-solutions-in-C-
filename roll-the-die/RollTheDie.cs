using System;

public class Player
{
    public int RollDie()
    {
        Random rng = new();
        return rng.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        Random rng = new();
        return (double)rng.NextSingle() * 100.0;
    }
}
