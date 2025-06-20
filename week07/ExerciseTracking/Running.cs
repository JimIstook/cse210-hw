using System;

public class Running : Activity
{
    private double _distance;

    public Running(int minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        double speed = (_distance / _timeSpent) * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _timeSpent / _distance;
        return pace;
    }
}