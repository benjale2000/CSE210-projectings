using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture s1 = new Scripture();

        bool finished = false;

        s1.DaProgram1();

        while (finished != true)
        {
            Console.WriteLine("Enter Y to continue");
            string keepgoing = Console.ReadLine();
            if (keepgoing == "Y")
            {
                s1.DaProgram2();
                finished = s1.DaProgram3();
            }
            else
            {
                Console.WriteLine("error, unknown input please try again");
            }
        }
        
    }
}