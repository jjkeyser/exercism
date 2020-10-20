using System;

public struct Clock : IEquatable<Clock>
{
    private const int MINUTESINHOUR = 60;
    private const int HOURSINDAY = 24;

    private int _hours;
    private int _minutes;

    public Clock(int hours, int minutes)
    {
        _hours = hours;
        _minutes = minutes;

        getClockTime();
    }

    public Clock Add(int minutesToAdd) => new Clock(_hours, _minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => Add(-minutesToSubtract);

    public void getClockTime()
    {
        _hours = _hours + _minutes / MINUTESINHOUR;
        _minutes = _minutes % MINUTESINHOUR;

        if (_minutes < 0) 
        {
            _minutes += MINUTESINHOUR;
            _hours--;
        }

        _hours = _hours % HOURSINDAY;

        if (_hours < 0) 
        { 
            _hours += HOURSINDAY;
        }
    }

    public override string ToString() => $"{_hours:D2}:{_minutes:D2}";

    public bool Equals(Clock clockToCompare) => ToString().Equals(clockToCompare.ToString());
}
