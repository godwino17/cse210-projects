using System;

public class Messages
{
    private string _activityName;
    private string _description;
    private int _time;
    //private int _number;
    

    public Messages(string activityName, string description) //, int number)
    {
        _activityName= activityName;
        _description= description;
        //_number= number;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetTime()
    {
        return _time;
    }

    public void DisplayFirstWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n\n{_description}.\n");
    }

    public int  AskForDurationInSeconds()
    {
        Console.Write("How long in seconds would you like for your session? ");
        string input= Console.ReadLine();
        _time=int.Parse(input);
        return _time;
    }
    
    public void DisplayPrepareMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void LoadingAnimation()
    {
        List<string> symbol= new List<string> {"|", "/", "-", "\\"};
        DateTime sTime= DateTime.Now;
        DateTime eTime= sTime.AddSeconds(3);
        int x=0;
        while (DateTime.Now < eTime)
        {
            string s= symbol[x];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            x++;
            if (x >= symbol.Count)
            {
                x=0;
            }
        }
    }

    public void DisplayWeldoneMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        LoadingAnimation();
        Console.WriteLine();
    }

    public void DisplayTimeSpent()
    {
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityName}.");
        LoadingAnimation();
        Console.Clear();
    }

    public void CountdownAni()
    {
        for (int number=5; number>0; number--)
        {
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}