using System;

public class Activity
{    
    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the activity you chose!");
    }

    public Random randomgenerator = new Random();

    public int GetDuration()
    {
        Console.WriteLine("Please put in the amount of minutes desired:");
        string DurationString = Console.ReadLine();
        int Duration = int.Parse(DurationString);
        return Duration;
    }

    public void Loading()
    {
        Console.WriteLine("...");
    }
}