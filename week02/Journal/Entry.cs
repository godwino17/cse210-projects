using System;
public class Entry
{
    public string _date;
    public string _textPrompt;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime= DateTime.Now;
        _date= theCurrentTime.ToShortDateString();

        PromptGenerator promptText= new PromptGenerator();
        _textPrompt= promptText.GetRandomGenerator();

        Console.Write($"{_textPrompt}\n> ");
        _entryText= Console.ReadLine();
        //Console.WriteLine(_entryText);
    }
}