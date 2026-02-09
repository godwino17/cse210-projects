using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq= new Square("Red",4);
        //sq.SetColor("Red");
        double result= sq.ComputeArea();
        string color= sq.GetColor();

        Rectangle rec= new Rectangle("Purple",5, 4);
        //rec.SetColor("Purple");
        rec.GetColor();
        rec.ComputeArea();

        Circle cir= new Circle("Orange",5);
        //cir.SetColor("Orange");
        cir.GetColor();
        cir.ComputeArea();

        List<Shape> sha= new List<Shape>();
        sha.Add(sq);
        sha.Add(rec);
        sha.Add(cir);

        foreach (Shape item in sha)
        {
            Console.WriteLine($"Shape color: {item.GetColor()} - Shape size: {item.ComputeArea()}");
        }


    }
}