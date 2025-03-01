using System;

public class Listing : Activity
{
    private string _message = "This is the listing activity, list as many items that come to mind.";

    List<string> ListPrompt = new List<string> {"Who do you appreicate?", "What are you good at?", "Who has helped you this week?", 
    "Who have you helped this week?", "When have you felt the Holy Ghost this week?", "What are some of the good things you are working on?"};

    List<string> Listed = new List<string> {};

    public void ListingIntro()
    {
        DisplayWelcome();
        Console.WriteLine(_message);
    }

    public void listingTime()
    {
        int duration = GetDuration();
        
        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(duration);

        Console.WriteLine(ListPrompt[randomgenerator.Next(0,5)]);

        while (starttime < endtime)
        {
            Listed.Add(Console.ReadLine());
            starttime = DateTime.Now;
        }

        Console.WriteLine("Thank you for listing things out, here is your list");

        foreach (string item in Listed)
        {
            Console.WriteLine();
            Console.Write($"{item} ");
        }
    }
}