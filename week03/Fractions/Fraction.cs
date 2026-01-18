using System;
using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top= 1;
        _bottom= 1;
    }

    public Fraction(int wholeNumber)
    {
        _top= wholeNumber;
        _bottom= 1;
    }

    public Fraction(int top, int bottom)
    {
        _top= top;
        _bottom= bottom;
    }


    public string GetFractionString()
    {
        return $"{_top.ToString()}/{_bottom.ToString()}";
    }

    public double GetDecimalValue()
    {
        double dbl= (double)_top;
        return dbl/_bottom;
    }
}