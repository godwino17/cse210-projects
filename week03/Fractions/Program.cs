using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac= new Fraction();
        Fraction frac1= new Fraction(5);
        Fraction frac2= new Fraction(3,4);

        string aval= frac.GetFractionString();
        double aval1= frac.GetDecimalValue();
        Console.WriteLine(aval);
        Console.WriteLine(aval1);

        string bval= frac1.GetFractionString();
        double bval1= frac1.GetDecimalValue();
        Console.WriteLine(bval);
        Console.WriteLine(bval1);

        string cval= frac2.GetFractionString();
        double cval1= frac2.GetDecimalValue();
        Console.WriteLine(cval);
        Console.WriteLine(cval1);

        Fraction newFrac= new Fraction(1,3);
        string dval= newFrac.GetFractionString();
        double dval1= newFrac.GetDecimalValue();
        Console.WriteLine(dval);
        Console.WriteLine(dval1);
    }
}