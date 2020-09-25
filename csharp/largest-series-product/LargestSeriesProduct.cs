using System;
using System.Linq;
public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        var largest = 0;

        if (!digits.All(Char.IsDigit))
        {
            throw new ArgumentException("String must only contain digits");
        }

        if (span > digits.Length || span < 0)
        {
            throw new ArgumentException("Invalid Span");
        }

        for (int i = 0; i < (digits.Length + 1) - span; i++)
        {
            var product = 1;
            
            foreach (var d in digits.Substring(i,span))
            {
                product *= (int)char.GetNumericValue(d);
            }

            largest = (largest > product) ? largest : product;
        }

        return largest;
    }
}