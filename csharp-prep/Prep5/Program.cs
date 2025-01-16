using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        welcome();

        string userName = theName();
        int userNumber = theNumber();

        int squaredNumber = squareNumber(userNumber);

        results(squaredNumber, userName);

        static void welcome()
        {
            Console.WriteLine("Welcome to the Program");
        }
        
        static string theName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int theNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }

        static int squareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void results (int squared, string name)
        {
            Console.WriteLine(name + ", the square of your number is " + squared);
        }
    }
}