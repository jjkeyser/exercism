using System;
using System.Collections.Generic;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int _month;
    private int _year;
    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int daysInMonth = DateTime.DaysInMonth(_year, _month);
        DateTime startDate = new DateTime(_year, _month, 1);
        DateTime endDate = new DateTime(_year, _month, daysInMonth);

        foreach(DateTime date in EachDay(startDate, endDate))
        {
            if (schedule == Schedule.Teenth)
            {
                if (date.DayOfWeek == dayOfWeek && date.Day > 12 && date.Day < 20)
                {
                    return date;
                }
            }
            if (schedule == Schedule.First)
            {
                if (date.DayOfWeek == dayOfWeek)
                {
                    return date;
                }
            }
        }
        return startDate;
    }
    public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
    {
        for(var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            yield return day;
    }
}