using System;

public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int fractionTop)
    {
        _top = fractionTop;
        _bottom = 1;
    }

    public Fraction(int bottomNum, int topNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    public string getfractionstring()
    {
        string fracstring = $"{_top}/{_bottom}";
        return fracstring;
    }

    public double getfractiondecimal()
    {
        double fracdecim = _top/_bottom;
        return fracdecim;
    }
}