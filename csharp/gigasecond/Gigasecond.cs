using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        const double Seconds = 1e9;
        return moment.AddSeconds(Seconds);
    }
}