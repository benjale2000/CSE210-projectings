using System;
using System.Security.Cryptography;

public class Reflect : Activity
{
    private string _message = "This is the reflection activity, reflect on the day.";

    List<string> ReflectPrompt = new List<string> {"Think of a time you brightened someones day.", 
    "Think of a time you were selfless.", "Think of a time you stood up to what you know.", 
    "Think of a time you had to do something hard.", "Think of a time you were inspired to do something."};

    List<string> ReflectQuestion = new List<string> {"Why was this meaningful to you?", 
    "Have you done something like this before?", "How difficult was this?", "What was the best part?", 
    "Did you learn something, and what was it?", "Did you learn something about yourself, and what was it?", 
    "Was this time different, how was it?"};

    List<string> ReflectAnswers = new List<string> {};

    public void ReflectIntro()
    {
        DisplayWelcome();
        Console.WriteLine(_message);
    }

    public void Reflecting()
    {
        int duration = GetDuration();

        DateTime starttime = DateTime.Now;
        DateTime endtime = starttime.AddSeconds(duration);

        Console.WriteLine(ReflectPrompt[randomgenerator.Next(0,4)]);
        Console.WriteLine(ReflectQuestion[randomgenerator.Next(0,6)]);

        while (starttime < endtime)
        {
            ReflectQuestion.Add(Console.ReadLine());
            starttime = DateTime.Now;
        }

        Console.WriteLine("You have finished, here is what you wrote:");
        foreach (string line in ReflectAnswers)
        {
            Console.WriteLine(line);
        }
    }
}