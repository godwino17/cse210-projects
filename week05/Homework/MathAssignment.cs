using System;

public class MathAssignment : Assignment
{
    private string _textBookSection="";
    private string _problems="";

    public  MathAssignment(string studentName, string topic, string textBook, string problem) : base(studentName, topic)
    {
        _textBookSection= textBook;
        _problems= problem;
    }

    public string GetHomeworkList()
    {
        //return $"{_studentName} - {_topic}\n{_textBookSection} {_problems}";
        return $"Section {_textBookSection} Problem {_problems}";
    }
}