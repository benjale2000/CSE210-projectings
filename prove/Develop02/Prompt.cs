using System;

public class PromptCreate
{
    List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", "How did I see the had of the Lord in my life today", 
    "What was the strongest emotion I felt today", "If I had one this I could do over today, what would it be?", 
    "What is something I am grateful for today?", "Did I experience a challenge today?", 
    "Have I overcome any challenges today?", "Did I make someone smile today?"};

    public string PromptGen()
    {
        Random randomgenerator = new Random();

        int ListNumber = prompts.Count;
        int IndexNum = randomgenerator.Next(0, ListNumber);
        
        string Prompt = prompts[IndexNum];
        return Prompt;
    }
}