using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        double gigasecond = Math.Pow(10, 9);
        return moment.AddSeconds(gigasecond);
    }
}