using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square sqr = new Square();
        Rectangle rct = new Rectangle();
        Circle crc = new Circle();

        Console.WriteLine(sqr.GetArea());
        Console.WriteLine(rct.GetArea());
        Console.WriteLine(crc.GetArea());
    }
}