using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException("square out of range");
        }
        return (ulong)Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        ulong totalGrains = 0;
        for (int i = 1; i <= 64; i++)
        {
            totalGrains += Square(i);
        }
        return totalGrains;
    }
}