using System;

public class Circle : Shape
{
    private double _radius = 0.00;

    public Circle() : base()
    {
        
    }

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        string color = Console.ReadLine();
        double radius = double.Parse(Console.ReadLine());
        _radius = radius;
        SetColor(color);
        
        return _radius * _radius * 3.14;
    }
}