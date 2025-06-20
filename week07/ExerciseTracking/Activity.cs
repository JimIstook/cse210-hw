using System;

public abstract class Activity
{
    protected DateOnly _date;
    protected string _name;
    protected int _timeSpent;

    public Activity(int minutes)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _timeSpent = minutes;
        _name = GetType().Name;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetSummary()
    {
        return $"{_date} {_name} ({_timeSpent} min): Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }

}