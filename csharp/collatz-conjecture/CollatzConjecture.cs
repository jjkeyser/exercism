using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int n = number;
        int steps = 0;

        if (n < 1)
        {
            throw new ArgumentOutOfRangeException("the number must be greater than zero");
        }

        while (n != 1)
        {
            n = (n % 2 == 0) ? n / 2 : 3 * n  + 1;
            steps++;
        }
        return steps;
    }
}