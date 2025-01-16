using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int chosen = 1;
        int loopCount = 0;
        int sum = 0;
        int total = 0;
        int average = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (chosen != 0)
        {
            Console.WriteLine("Enter number: ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            numbers.Add(number);
            chosen = number;
            loopCount = loopCount + 1;
        }
        Console.WriteLine(loopCount);

        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine("The sum is: " + sum);

        foreach (int number in numbers)
        {
            total = total + number;
        }
        loopCount = loopCount - 1;
        average = total / loopCount;
        Console.WriteLine("The average is: " + average);

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine("The largest number is: " + largest);
    }
}