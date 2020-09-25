using System;
using System.Linq;
public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        var largestProduct = 0;

        if (span == 0)
        {
            largestProduct = 1;
        }

        foreach (char d in digits)
        {
            if (!char.IsDigit(d))
            {
                throw new ArgumentException("String must only contain digits");
            }
        }

        if (span > digits.Length || span < 0)
        {
            throw new ArgumentException("Invalid Span");
        }

        for (int i = 0; i < (digits.Length + 1) - span; i++)
        {
            var currentProduct = 1;
            
            foreach (var d in digits.Substring(i,span))
            {
                currentProduct *= (int)char.GetNumericValue(d);
            }

            if (currentProduct > largestProduct)
            {
                largestProduct = currentProduct;
            }
        }

        return largestProduct;
    }
}