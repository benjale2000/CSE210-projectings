using System;

public class Square : Shape
{
    private double _side = 0.00;

    public Square() : base()
    {
        
    }
    
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    
    public override double GetArea()
    {
        string color = Console.ReadLine();
        double side = double.Parse(Console.ReadLine());
        _side = side;
        SetColor(color);

        return _side * _side;
    }
}