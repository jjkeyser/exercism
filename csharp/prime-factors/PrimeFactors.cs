using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> primeFactors = new List<long>();

        for (int a = 2; number > 1; a++) 
        {
            if (number % a == 0) 
            {
                while (number % a == 0) 
                {
                    primeFactors.Add(a);
                    number /= a;
                }
            }
        }

        return primeFactors.ToArray();
    }
}