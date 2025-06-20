using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / _timeSpent) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _timeSpent / CalculateDistance();
        return pace;
    }
}