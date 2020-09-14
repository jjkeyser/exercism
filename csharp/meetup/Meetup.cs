using System;
using System.Linq;

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
        DateTime startDate = new DateTime(_year, _month, 1);
        var day_list = Enumerable.Range(1, DateTime.DaysInMonth(_year, _month))
                                  .Select(day => new DateTime(_year, _month, day))
                                  .Where(day => day.DayOfWeek == dayOfWeek)
                                  .ToList();

        switch (schedule)
        {
            case Schedule.First:
                return day_list[0];
            case Schedule.Second:
                return day_list[1];
            case Schedule.Third:
                return day_list[2];
            case Schedule.Fourth:
                return day_list[3];
            case Schedule.Last:
                return day_list.Last();
            case Schedule.Teenth:
                return day_list.First(date => date.Day > 12 && date.Day < 20 );
            default:
                throw new ArgumentException("Invalid arguments. A meetup date was unable to be determined");
        }                        
    }
}