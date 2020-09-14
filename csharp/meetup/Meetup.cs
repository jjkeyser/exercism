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
        switch (schedule)
        {
            case Schedule.Teenth:
                startDate = new DateTime(_year, _month, 13);
                endDate = new DateTime(_year, _month, 19);
                break;
            case Schedule.First:
                startDate = new DateTime(_year, _month, 1);
                endDate = new DateTime(_year, _month, 7);
                break;
            case Schedule.Second:
                startDate = new DateTime(_year, _month, 8);
                endDate = new DateTime(_year, _month, 14);
                break;
            case Schedule.Third:
                startDate = new DateTime(_year, _month, 15);
                endDate = new DateTime(_year, _month, 21);
                break;
            case Schedule.Fourth:
                startDate = new DateTime(_year, _month, 22);
                endDate = new DateTime(_year, _month, daysInMonth);
                break;
            case Schedule.Last:
                startDate = new DateTime(_year, _month, daysInMonth - 6);
                endDate = new DateTime(_year, _month, daysInMonth);
                break;
            default:
                break;
        }

        foreach(DateTime date in EachDay(startDate, endDate))
        {
            if(date.DayOfWeek == dayOfWeek)
            {
                return date;
            }
        }
        throw new ArgumentException("Invalid arguments. Meetup date could not be determined.");
    }
    public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
    {
        for(var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            yield return day;
    }
}