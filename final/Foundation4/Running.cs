using System;

public class Running : Activity
{
    private double _distance = 0;

    public Running(double distance, string date, int time) : base(date, time)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine(GetDateTime());
        Console.WriteLine($"The distance was {_distance}, making the speed {CalculateSpeed(_distance)}, the pace {CalculatePace(_distance)}");
    }
}