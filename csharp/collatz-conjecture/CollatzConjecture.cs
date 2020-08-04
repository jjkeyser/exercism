using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;

        if (number < 1)
        {
            throw new ArgumentOutOfRangeException("the number must be greater than zero");
        }

        while (number != 1)
        {
            number = (number % 2 == 0) ? number / 2 : 3 * number  + 1;
            steps++;
        }
        return steps;
    }
}