using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> series = new List<string>();

        if (sliceLength > numbers.Length || sliceLength < 1 || numbers == "") {
            throw new ArgumentException();
        }

        for (int i = 0; i < numbers.Length - sliceLength + 1; i++) {
            series.Add(numbers.Substring(i, sliceLength));
        }

        return series.ToArray();
    }
}