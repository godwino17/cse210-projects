using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse= -1) // Constructor 1 with optional parameter
    {
        _book= book;
        _chapter= chapter;
        _verse= verse;
        _endVerse= endVerse; // if the is no end verse
    }
    public string GetDisplayText() // function
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}"; // What to return if no end verse.
        }
        else
        {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // What to return if the is end verse.
        }
    }
}