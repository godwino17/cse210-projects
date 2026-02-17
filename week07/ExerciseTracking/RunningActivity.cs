using System;

public class RunningActivity : Activity
{
    private double _distanceInKm;
    public RunningActivity(string date, int duration, double distance): base(date, duration)
    {
        _distanceInKm= distance;
    }

    public override double GetDistance()
    {
        return  _distanceInKm;
    }
    public override double GetSpeed()
    {
        return _distanceInKm / (GetDuration() * 60);
    }
    public override double GetPace()
    {
        return GetDuration() / _distanceInKm;
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetDuration()} min): Distance {GetDistance()} Km, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per Km");
    }
}