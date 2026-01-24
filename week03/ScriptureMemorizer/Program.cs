using System;

class Program
{
    static void Main(string[] args)
    {
        // Program Title.
        Console.WriteLine("Welcome to Scripture Memorizer Program");
        Console.WriteLine();
        
        string action = "";

        // Create the verse and reference once
        Reference reference= new Reference("Proverbs",3,5,6);
        Scripture scripture= new Scripture(reference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        while (action != "quit") //(true) ✅
        {
            Console.Clear(); // clear screen each time
            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            action = Console.ReadLine();

            if (action != null && action.Trim().ToLower() == "quit")
            {
                break; // exit loop
            }

        }
    }
}
