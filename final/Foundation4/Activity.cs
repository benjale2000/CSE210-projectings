using System;
using System.Dynamic;

public abstract class Activity
{
    private string _date = "";
    private int _time = 0;

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public abstract void GetSummary();

    public string GetDateTime()
    {
        return $"{_date}, ran for {_time}.";
    }

    public double CalculateSpeed(double distance)
    {
        double speed = distance/_time;
        return speed;
    }

    public double CalculatePace(double distance)
    {
        double pace = _time/distance;
        return pace;
    }
}