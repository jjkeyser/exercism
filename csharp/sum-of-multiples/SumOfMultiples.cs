using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> countedMultiples = new HashSet<int>();
        for (int i = 1; i < max; i++)
        {
            foreach (int m in multiples)
            {
                if (m != 0 && i % m == 0)
                {
                    countedMultiples.Add(i);
                }
            }
        }
        return countedMultiples.Sum();
    }
}