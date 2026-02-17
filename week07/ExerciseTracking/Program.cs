using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList= new List<Activity>();

        Activity running= new RunningActivity("02-17-2026", 30, 4.8);
        Activity cycling= new CyclingActivity("02-17-2026", 25, 10);
        Activity swimming= new SwimmingActivity("02-17-2026", 20, 4);
        Activity running1= new RunningActivity("02-17-2026", 45, 7.2);

        activityList.Add(running);
        activityList.Add(swimming);
        activityList.Add(cycling);
        activityList.Add(running1);

        
        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
        }
    }
}