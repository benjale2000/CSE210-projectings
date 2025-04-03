using System;

public class Lectures : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lectures(string speaker, int capacity, string eventtitle, string description, string date, string time, string address) : base(eventtitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFull()
    {
        Display();
        Console.WriteLine($"The speaker is {_speaker}");
        Console.WriteLine($"Capacity is {_capacity}");
    }
}