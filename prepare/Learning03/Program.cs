using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.getfractionstring());
        Console.WriteLine(f1.getfractiondecimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.getfractionstring());
        Console.WriteLine(f2.getfractiondecimal());

        Fraction f3 = new Fraction(4, 3);
        Console.WriteLine(f3.getfractionstring());
        Console.WriteLine(f3.getfractiondecimal());

        Fraction f4 = new Fraction(3, 1);
        Console.WriteLine(f4.getfractionstring());
        Console.WriteLine(f4.getfractiondecimal());
        
    }
}