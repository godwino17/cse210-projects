using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        // string nums= Console.ReadLine();
        // int number= int.Parse(nums);

        List<int> numbers= new List<int>();
        int number= -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int total= 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string nums= Console.ReadLine();
            number= int.Parse(nums);

            if (number !=0)
            {
                numbers.Add(number);
            }
        }
        int maxNum= numbers[0];
        int smallPosi= 999999999;
        foreach (int num in numbers)
        {
            total += num;
            if (num > maxNum)
            {
                maxNum = num;
            }

            if (num > 0 && num < smallPosi)
            {
                smallPosi = num;
            }
        }
        
        Console.WriteLine($"The sum is: {total}");
        double average= (double)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");
        Console.WriteLine($"The smallest positive number is: {smallPosi}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        } 
    }
}