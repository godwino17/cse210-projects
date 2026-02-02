using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment= new Assignment("Samuel Bennett", "Multiplication");
        string result= assignment.GetSummary();
        Console.WriteLine(result);
        Console.WriteLine();

        
        MathAssignment mAssignment= new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mAssignment.GetSummary());
        Console.WriteLine(mAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment wAssignment= new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInfo());
    }
}