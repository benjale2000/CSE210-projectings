using System;
using System.Diagnostics.Tracing;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hi this is the base where everything happens.");
        Menu menu = new Menu();
        Journal journal = new Journal();
        Entry entry = new Entry();
        PromptCreate prompt = new PromptCreate();

        string loop = "1";

        while (loop != "5")
        {
            menu.MenuDisplay();
            loop = Console.ReadLine();

            if (loop == "1")
            {
                Console.WriteLine("You have selected option 1.");
                string display = prompt.PromptGen();
                Console.WriteLine(display);
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;
                entry._promptText = display;
                entry._promptText = Console.ReadLine();

            }
            else if (loop == "2")
            {
                Console.WriteLine("You have selected option 2.");
                entry.Display();
            }
            else if (loop == "3")
            {
                Console.WriteLine("You have selected option 3.");
                journal.SaveToFile(entry._date, entry._promptText, entry._entryText);
            }
            else if (loop == "4")
            {
                Console.WriteLine("You have selected option 4.");
                journal.LoadFromFile();
            }
            else if (loop == "5")
            {
                Console.WriteLine("You have selected option 5.");
                Console.WriteLine("Have a lovely day.");
            }
            else
            {
                Console.WriteLine("Error, unknown input, please try again");
            }
        }
    }
}