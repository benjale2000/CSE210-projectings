using System;

public class Swimming : Activity
{
    private int _laps = 0;
    private double _distance = 0;

    public Swimming(int laps, string date, int time) : base(date, time)
    {
        _laps = laps;
        GetDistance();
    }

    public override void GetSummary()
    {
        
        Console.WriteLine(GetDateTime());
        Console.WriteLine($"The laps swum is {_laps}.");
        Console.WriteLine($"The distance was {_distance}, making the speed {CalculateSpeed(_distance)}, the pace {CalculatePace(_distance)}.");
    }

    public void GetDistance()
    {
        _distance = _laps * 50 / 1000;
    }
}