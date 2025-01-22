using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        string Play = " ";
        string win = " ";

        string R1C1 = "Q";
        string R2C1 = "Q";
        string R3C1 = "Q";
        string R4C1 = "Q";
        string R5C1 = "Q";
        string R6C1 = "Q";
        string R7C1 = "Q";
        string R8C1 = "Q";
        string R1C2 = "Q";
        string R2C2 = "Q";
        string R3C2 = "Q";
        string R4C2 = "Q";
        string R5C2 = "Q";
        string R6C2 = "Q";
        string R7C2 = "Q";
        string R8C2 = "Q";
        string R1C3 = "Q";
        string R2C3 = "Q";
        string R3C3 = "Q";
        string R4C3 = "Q";
        string R5C3 = "Q";
        string R6C3 = "Q";
        string R7C3 = "Q";
        string R8C3 = "Q";
        string R1C4 = "Q";
        string R2C4 = "Q";
        string R3C4 = "Q";
        string R4C4 = "Q";
        string R5C4 = "Q";
        string R6C4 = "Q";
        string R7C4 = "Q";
        string R8C4 = "Q";
        string R1C5 = "Q";
        string R2C5 = "Q";
        string R3C5 = "Q";
        string R4C5 = "Q";
        string R5C5 = "Q";
        string R6C5 = "Q";
        string R7C5 = "Q";
        string R8C5 = "Q";
        string R1C6 = "Q";
        string R2C6 = "Q";
        string R3C6 = "Q";
        string R4C6 = "Q";
        string R5C6 = "Q";
        string R6C6 = "Q";
        string R7C6 = "Q";
        string R8C6 = "Q";
        string R1C7 = "Q";
        string R2C7 = "Q";
        string R3C7 = "Q";
        string R4C7 = "Q";
        string R5C7 = "Q";
        string R6C7 = "Q";
        string R7C7 = "Q";
        string R8C7 = "Q";
        string R1C8 = "Q";
        string R2C8 = "Q";
        string R3C8 = "Q";
        string R4C8 = "Q";
        string R5C8 = "Q";
        string R6C8 = "Q";
        string R7C8 = "Q";
        string R8C8 = "Q";

        void gridspace()
        {
            Console.WriteLine($"{R1C1},{R1C2},{R1C3},{R1C4},{R1C5},{R1C6},{R1C7},{R1C8}");
            Console.WriteLine($"{R2C1},{R2C2},{R2C3},{R2C4},{R2C5},{R2C6},{R2C7},{R2C8}");
            Console.WriteLine($"{R3C1},{R3C2},{R3C3},{R3C4},{R3C5},{R3C6},{R3C7},{R3C8}");
            Console.WriteLine($"{R4C1},{R4C2},{R4C3},{R4C4},{R4C5},{R4C6},{R4C7},{R4C8}");
            Console.WriteLine($"{R5C1},{R5C2},{R5C3},{R5C4},{R5C5},{R5C6},{R5C7},{R5C8}");
            Console.WriteLine($"{R6C1},{R6C2},{R6C3},{R6C4},{R6C5},{R6C6},{R6C7},{R6C8}");
            Console.WriteLine($"{R7C1},{R7C2},{R7C3},{R7C4},{R7C5},{R7C6},{R7C7},{R7C8}");
            Console.WriteLine($"{R8C1},{R8C2},{R8C3},{R8C4},{R8C5},{R8C6},{R8C7},{R8C8}");
        }

        void input()
        {
            Console.WriteLine("Please input the location for move");
        }

        void WinCondition()
        {

        }

        void game()
        {
            while(Play != "N");
            {
                Console.WriteLine("Would you like to play connect four? Please answer with Y or N");
                Play = Console.ReadLine();

                if (Play == "Y")
                {
                    Console.WriteLine("We will begin the game Q means empty, 1 is player one, 2 is player two.");
                    while (win != "W")
                    {
                    gridspace();
                    }
                }
                else if (Play == "N")
                {
                    Console.WriteLine("We will end the program now.");
                }
                else 
                {
                    Console.WriteLine("Error, unknown input, Please try again.");
                }
            }
        }
    }
}