using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> primeFactors = new List<long>();
        long divisor = 2;
        long numerator = number;

        while (numerator != 1) 
        {
            if (numerator % divisor == 0) 
            {
                numerator /= divisor;
                primeFactors.Add(divisor);
            }
            else 
            {
                divisor++;
            }
        }

        return primeFactors.ToArray();
    }
}