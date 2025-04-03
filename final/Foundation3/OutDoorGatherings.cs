using System;

public class OutdoorGatherings : Event
{
    private string _weatherforcast = "";

    public OutdoorGatherings(string weatherforcast, string eventtitle, string description, string date, string time, string address) : base(eventtitle, description, date, time, address)
    {
        _weatherforcast = weatherforcast;
    }

    public void DisplayFull()
    {
        Display();
        Console.WriteLine($"The weather will be {_weatherforcast}");
    }
}