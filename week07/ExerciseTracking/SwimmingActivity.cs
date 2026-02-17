using System;

public class SwimmingActivity : Activity
{
    private int _lap;
    public SwimmingActivity(string date, int duration, int SwimmingLap): base(date, duration)
    {
        _lap= SwimmingLap;
    }

    public override double GetDistance()
    {
        return _lap * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} swimming ({GetDuration()} min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per Km");
    }
}