using System;

public class Rectangle : Shape
{
    private double _length = 0.00;
    private double _width = 0.00;

    public Rectangle() : base()
    {

    }

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        string color = Console.ReadLine();
        double length = double.Parse(Console.ReadLine());
        _length = length;
        double width = double.Parse(Console.ReadLine());
        _width = width;
        SetColor(color);

        return length * width;
    }
}