using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order o1 = new Order();
        Order o2 = new Order();

        o1.GetCustomer("Erika", "Saunders", "12345 blah street" ,"Portland" ,"Oregon" ,"USA", false);
        o1.GetProduct("Sacks of Potatoes", "13442", 4, 10);
        o1.GetProduct("Boxes of Eggs", "10999", 6, 10);
        o1.GetProduct("Boxes of Mayonaise", "15887", 5, 10);
        o1.GetShippingTotal();

        o2.GetCustomer("Akane", "Yamakaze", "12345 Miko street" ,"Tokyo" ,"Kanto" ,"Japan", true);
        o2.GetProduct("Wheat Flour Sacks", "11111", 3, 5);
        o2.GetProduct("Red Bean Sacks", "14675", 5, 4);
        o2.GetProduct("Dried Seaweed Boxes", "34778", 7, 6);
        o2.GetShippingTotal();

        o1.Display();

        o2.Display();
    }
}