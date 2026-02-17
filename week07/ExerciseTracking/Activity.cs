using System;

public abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date= date;
        _duration= duration;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} Exercise ({_duration} min)...");
    }
}