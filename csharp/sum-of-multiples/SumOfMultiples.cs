using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> countedMultiples = new HashSet<int>();
        foreach (int multiple in multiples)
        {
            for (int i = multiple; i < max; i++)
            {
                if (multiple != 0 && i % multiple == 0)
                {
                    countedMultiples.Add(i);
                }
            }
        }
        return countedMultiples.Sum();
    }
}