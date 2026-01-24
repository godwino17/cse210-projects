using System;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random= new Random(); // NOT MY WORK AI

    public Scripture(Reference reference, string text)
    {
        _reference= reference;
        _words= text.Split(' ').Select(w=> new Word(w)).ToList(); // this will convert the text to a list of Word
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        
    }
    public bool IsCompletelyHidden()
    {
        
    }
}