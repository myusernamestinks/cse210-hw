using System;

public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * _duration / 60.0;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return base.GetSummary() + $" - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min/mile";
    }
}
