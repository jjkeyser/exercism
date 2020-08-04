using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int n = number;
        int steps = 0;

        if (n <= 0)
        {
            throw new ArgumentOutOfRangeException("the number must be greater than zero");
        }

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n = n / 2;
            } else
            {
                n = (3 * n ) + 1;
            }
            steps++;
        }
        return steps;
    }
}