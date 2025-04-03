using System;

public class Receptions : Event
{
    List<string> ThoseAttending = new List<string>{};

    private int _capacity = 0;

    public Receptions(int capacity, string eventtitle, string description, string date, string time, string address) : base(eventtitle, description, date, time, address)
    {
        _capacity = capacity;
    }

    public void DisplayFull()
    {
        Display();
        Console.WriteLine($"The capacity is {_capacity}");
        foreach (var person in ThoseAttending)
        {
            Console.Write($"{person}, ");
        }
    }

    public void RegisterList(string personname)
    {
        ThoseAttending.Add(personname);
    }
}