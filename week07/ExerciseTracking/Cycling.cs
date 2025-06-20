using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _timeSpent;
        return distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        double pace = _timeSpent / CalculateDistance();
        return pace;
    }
}