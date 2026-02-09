using System;
public abstract class Shape
{
    private string _color= "";

    public Shape(string color)
    {
        _color= color;
    }

    public void SetColor(string color)
    {
         _color= color;
    }

    public string GetColor()
    {
        return _color;
    }

    // public virtual double ComputeArea() //
    // {
    //     return 1.23;
    // }

    // Using abstract method instead of Virtual because no need to define the body here since it will be
    // overwritten in other classes.
    public abstract double ComputeArea();
}