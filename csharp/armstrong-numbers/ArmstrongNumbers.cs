using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string numberString = number.ToString();
        int power = numberString.Length;
        double sum = 0;

        foreach (char n in numberString)
        {
            sum += (int)Math.Pow((int)char.GetNumericValue(n), numberString.Length);
        }

        return sum == number;
    }
}