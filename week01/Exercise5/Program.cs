using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
    
        DisplayWelcome();

        static string PromtUserName()
        {
            Console.Write("Please enter your name: ");
            string name= Console.ReadLine();
            return name;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string nums= Console.ReadLine();
            int number= int.Parse(nums);
            return number;
        }

        static int SquareNumber(int num)
        {
            int SquareNum= num * num;
            return SquareNum;
        }

        static string DisplayResult(string userName, int SqrNum)
        {
            return $"{userName}, the square of your number is {SqrNum}";
        }

        static void main()
        {
            string name= PromtUserName();
            int number= PromtUserNumber();
            int square= SquareNumber(number);
            string displayDetails= DisplayResult(name, square);
            Console.WriteLine(displayDetails);
        }

        main();
    }
}