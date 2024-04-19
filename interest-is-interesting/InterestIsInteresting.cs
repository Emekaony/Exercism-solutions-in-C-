using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 0.0f;
        if (balance < 0m)
        {
            rate = 3.213f;
        }
        else if (balance >= 0 && balance < 1000m)
        {
            rate = 0.5f;
        }
        else if (balance >= 1000m && balance < 5000m)
        {
            rate = 1.621f;
        }
        else if (balance >= 5000m)
        {
            rate = 2.475f;
        }
        return rate;
    }

    public static decimal Interest(decimal balance) => balance * (decimal)(InterestRate(balance) / 100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        double top = Math.Log10(decimal.ToDouble(targetBalance / balance));
        double bottom = Math.Log10(1 + InterestRate(balance) * 1 / 100);
        return (int)Math.Ceiling(top / bottom);
    }
}
