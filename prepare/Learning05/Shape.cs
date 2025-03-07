using System;
using System.Drawing;

public abstract class Shape
{
    private string _color = "";

    public Shape()
    {
        
    }

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        string color = Console.ReadLine();
        return color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}