using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


// I have already provide the file type
// The user just has to type the file name, without adding the extension.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal= new Journal();

        string option = "";
        while (option != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();


            if (option == "1")
            {
                Entry entry = new Entry();
                entry.Display();
                journal.AddEntry(entry);
            }

            else if (option== "2")
            {
                journal.DisplayAll();
            }
            
            else if (option== "3")
            {
                // I added the file type/extension
                string fileType= ".csv"; // I added the file type/extension
                Console.WriteLine("What is the filename (Do not include extension)? ");
                String fileL= Console.ReadLine();
                string fil= $"{fileL}{fileType}"; // I added the file type/extension
                journal.LoadFromFile($"{fil}");

            }
            else if (option== "4")
            {
                // I added the file type/extension
                string fileType= ".csv"; // I added the file type/extension
                Console.WriteLine("What is the filename (Do not include extension)? ");
                String fileS= Console.ReadLine();
                string fil= $"{fileS}{fileType}"; // I added the file type/extension
                journal.SaveToFile($"{fil}");
            }
        }
    }
}