using System;

public class Clock : IEquatable<Clock>
{
    private const int MINUTESINHOUR = 60;
    private const int HOURSINDAY = 24;

    public int Hours {get; set;}
    public int Minutes {get; set;}

    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;

        getClockTime();
    }

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => Add(-minutesToSubtract);

    public void getClockTime()
    {
        Hours = Hours + Minutes / MINUTESINHOUR;
        Minutes = Minutes % MINUTESINHOUR;

        if (Minutes < 0) 
        {
            Minutes += MINUTESINHOUR;
            Hours--;
        }

        Hours = Hours % HOURSINDAY;

        if (Hours < 0) 
        { 
            Hours += HOURSINDAY;
        }
    }

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";

    public bool Equals(Clock clockToCompare) => ToString().Equals(clockToCompare.ToString());
}
