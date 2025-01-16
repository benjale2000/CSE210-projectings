using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guessNumber = 0;

        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guessString = Console.ReadLine();
            guessNumber = int.Parse(guessString);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}