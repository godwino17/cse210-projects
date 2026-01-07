using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        string game= "";

        while (game != "no")
        {
            // Console.Write("What is the magic number? ");
            // string num= Console.ReadLine();
            // int number= int.Parse(num);
            Random random= new Random();
            int number= random.Next(1, 101);

            int guess= -1;
            int counter= 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string gu= Console.ReadLine();
                guess= int.Parse(gu);

                counter += 1;

                if (guess > number)
                {
                    Console.WriteLine("Go lower!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Go higher!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {counter} guesses.");

            Console.Write("Would you like to play again (Yes/no): ");
            game= Console.ReadLine().ToLower();
        }
    }
}