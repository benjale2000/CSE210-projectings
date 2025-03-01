using System;

public class Breathing : Activity
{
    private string _message = "This is the breathing activity, prepare to relax through breathing.";

    public void BreathIntro()
    {
        DisplayWelcome();
        Console.WriteLine(_message);
    }

    public void BreathingAnimation()
    {
        Console.WriteLine("Breathe in...");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Breathe out...");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.WriteLine();
    }
    
    public void DoingBreathing()
    {
        int duration = GetDuration();
        DateTime starttime = DateTime.Now;
        DateTime futuretime = starttime.AddSeconds(duration);

        while (starttime < futuretime)
        {
            BreathingAnimation();
            starttime = DateTime.Now;
        }
    }
}