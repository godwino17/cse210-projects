using System;

public class BreathingActivity : Messages
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
        
    }

    public void DisplayBreathing()
    {
        Console.WriteLine();
        Console.Write($"Breathe In...");
        CountdownAni();
        Console.WriteLine("\b\b");
        Console.Write($"Now breathe Out...");
        CountdownAni();
        Console.WriteLine();
    }
}