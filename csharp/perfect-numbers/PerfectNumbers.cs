﻿using System;
using System.Collections.Generic;
using System.Linq;
public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        var aliquotSum = GetFactors(number).Sum();
        
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException("not a natural number");
        }
        
        if (aliquotSum == number)
        {
            return Classification.Perfect;
        } else if (aliquotSum > number)
        {
            return Classification.Abundant;
        } else
        {
            return Classification.Deficient;
        }
    }

    private static IEnumerable<int> GetFactors(int number)
    {
        var factors = new HashSet<int>();

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }
        return factors;
    }
}
