using System;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlTypes;

public class Journal
{
    public List<Entry> _entries= new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        
        if (_entries.Count==0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
        
        foreach (Entry entry in _entries)
        {
            
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._textPrompt}\n{entry._entryText}\n");
        }
        
    }

    public void SaveToFile(string filename)
    {
        if (_entries.Count==0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }
        using (StreamWriter writeToFile= new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            
            {
                //writeToFile.WriteLine($"{entry._date}~~{entry._textPrompt}~~{entry._entryText}"); //✅
                writeToFile.WriteLine($"{entry._date},{entry._textPrompt},{entry._entryText}"); // Save as csv file
            }
        }
        Console.WriteLine("File saved successfully.");
    }


    public void LoadFromFile(string filename)
    {
        if (string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("Please enter a correct filename.");
            return;
        }
        else if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string [] lines= System.IO.File.ReadAllLines(filename);
        _entries.Clear(); 
        foreach (string line in lines)
        {
            //string[] parts = line.Split("~~"); //✅
            string[] parts = line.Split(",");// Load as a csv file.

            if (parts.Length == 3)
            {
                Entry fileEntry= new Entry(); 
                fileEntry._date= parts[0]; 
                fileEntry._textPrompt= parts[1]; 
                fileEntry._entryText= parts[2]; 

                _entries.Add(fileEntry); 
            }

        }
        Console.WriteLine("Entries loaded successfully.");

    }

}
