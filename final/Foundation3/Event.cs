using System;
using System.ComponentModel.DataAnnotations;

public class Event
{
    private string _eventtitle = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";

    public Event(string eventtitle, string description, string date, string time, string address)
    {
        _eventtitle = eventtitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event()
    {}

    public void Display()
    {
        Console.WriteLine(_eventtitle);
        Console.WriteLine(_description);
        Console.WriteLine($"The event will occur on {_date} {_time}");
        Console.WriteLine($"The event is located at {_address}");
    }
}