using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool isHidden= false) // Constructor with optional parameter.
    {
        _text= text;
        _isHidden= isHidden;
    }

    public void Hide() // function
    {
        _isHidden= true;
    }

    public void Show() // function
    {
        _isHidden= false;
    }

    public bool IsHidden() // function
    {
        return _isHidden;
    }

    public string GetDisplayText() // function
    {
        if (_isHidden==true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}