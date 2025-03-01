using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Breathing breathactive = new Breathing();
        Reflect reflectactive = new Reflect();
        Listing listactive = new Listing();

        int loop = 1;

        while (loop != 0)
        {
            string choice = "";

            Console.WriteLine("Welcome please choose which activity you wish to use.");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflect");
            Console.WriteLine("3. List");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathactive.BreathIntro();
                breathactive.DoingBreathing();
            }
            else if (choice == "2")
            {
                reflectactive.ReflectIntro();
                reflectactive.Reflecting();
            }
            else if (choice == "3")
            {
                listactive.ListingIntro();
                listactive.listingTime();
            }
            else
            {
                Console.WriteLine("Sorry invalid input.");
                loop = 0;
            }
        }
    }
}