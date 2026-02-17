using System;

public class CyclingActivity : Activity
{
    private double _speed;
    
    public CyclingActivity(string date, int duration, double speed): base(date, duration)
    {
        _speed= speed;
    }
    public override double GetDistance()
    {
        return _speed * GetDuration();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetDuration()} min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per Km");
    }
}