using System;

class Program
{
    static void Main(string[] args)
    {
        string action= "";
        while (true)
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine("  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            action= Console.ReadLine();

            if (action == "4")
            {
                break;
            }
            else if (action== "1")
            {
                BreathingActivity breath= new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                breath.DisplayFirstWelcomeMessage();
                breath.AskForDurationInSeconds();
                breath.DisplayPrepareMessage();
                breath.LoadingAnimation();
                Console.WriteLine();

                int time=breath.GetTime();
                DateTime sTime= DateTime.Now;
                DateTime eTime= sTime.AddSeconds(time);
                while (DateTime.Now< eTime)
                {
                breath.DisplayBreathing();
                //time--;
                if (sTime==eTime)
                    {
                        break;
                    }
                }

                breath.DisplayWeldoneMessage();
                breath.DisplayTimeSpent();
            }

            else if (action== "2")
            {
                ReflectingActivity reflect= new ReflectingActivity("Reflecting Activity",  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life");
                reflect.DisplayFirstWelcomeMessage();
                reflect.AskForDurationInSeconds();
                reflect.DisplayPrepareMessage();
                reflect.LoadingAnimation();

                Console.WriteLine();//
                reflect.RandomPrompt();
                Console.WriteLine("When you have something in mind, press enter to continue. ");
                string input= Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
                Console.Write("You may begin in: ");
                reflect.CountdownAni();
                Console.Clear();

                int time=reflect.GetTime();
                DateTime sTime= DateTime.Now;
                DateTime eTime= sTime.AddSeconds(time);
                while (DateTime.Now< eTime)
                {
                    Console.Write(reflect.RandomPromptQuestion());
                    reflect.Animation();
                    Console.WriteLine(); //s
                    if (sTime==eTime)
                    {
                        break;
                    }
                }
                reflect.DisplayWeldoneMessage();
                reflect.DisplayTimeSpent();
            }

            else if (action=="3")
            {
                ListingActivity lists= new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                lists.DisplayFirstWelcomeMessage();
                lists.AskForDurationInSeconds();
                lists.DisplayPrepareMessage();
                lists.LoadingAnimation();
                Console.WriteLine();
                lists.DisplayPrompt();
                lists.CountdownAni();
                Console.WriteLine();//st

                int time=lists.GetTime();
                DateTime sTime= DateTime.Now;
                DateTime eTime= sTime.AddSeconds(time);
                int count=0;
                while (DateTime.Now < eTime)
                {
                    Console.Write("> ");
                    string input= Console.ReadLine();
                    count++;

                    if (sTime==eTime)
                    {
                        break;
                    }                 
                }
                Console.WriteLine($"You have listed {count} items!");
                lists.DisplayWeldoneMessage();
                lists.DisplayTimeSpent();
                Console.Clear();
            }
        }
    }
}