using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string gradeLetter = "L";

        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber < 90 && gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber < 80 && gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber < 70 && gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine("Your grade is a " + gradeLetter);
        
        if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}