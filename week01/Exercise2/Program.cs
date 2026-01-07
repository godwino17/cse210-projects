using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade= Console.ReadLine();
        float score= float.Parse(grade);

        string sign= "";

        string letter= "";
        float scoreDiv= score % 10;



        if (score >= 90)
        {
            if (scoreDiv <= 3)
            {
                sign = "-";
            }
            letter= "A";
        }
        else if (score >= 80)
        {
            if (scoreDiv <= 3)
            {
                sign = "-";
            }
            else if (scoreDiv >= 7)
            {
                sign = "+";
            }
            letter= "B";
        }
        else if (score >= 70)
        {
            if (scoreDiv <= 3)
            {
                sign = "-";
            }
            else if (scoreDiv >= 7)
            {
                sign = "+";
            }
            letter= "C";
        }
        else if (score >= 60)
        {
            if (scoreDiv <= 3)
            {
                sign = "-";
            }
            else if (scoreDiv >= 7)
            {
                sign = "+";
            }
            letter= "D";
        }
        else
        {
            letter= "F";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        


        if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}