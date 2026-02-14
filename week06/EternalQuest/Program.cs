using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string action= "";
        List<Goal> gList= new List<Goal>();
        int score= 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine();

            Console.Write("Menu Option:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect  a choice from the menu: ");
            action= Console.ReadLine();
            Console.WriteLine();

            if (action== "6")
            {
                break;
            }
            else if (action== "1")
            {
                // create goal
                Console.Write("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of Goal would you like to create? ");
                string choice =Console.ReadLine();
                

                if (choice== "1")
                {
                    // simple goal
                    Console.Write("What is the name of your Goal? ");
                    string name= Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description= Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int point= int.Parse(Console.ReadLine());
                    SimpleGoal sg= new SimpleGoal(name, description, point);
                    gList.Add(sg);
                }
                else if (choice== "2")
                {
                    // eternal goal
                    Console.Write("What is the name of your Goal? ");
                    string name= Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description= Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int point= int.Parse(Console.ReadLine());
                    EternalGoal eg= new EternalGoal(name, description, point);
                    gList.Add(eg);
                                  
                }
                else if (choice== "3")
                {
                    // checklist goal
                    Console.Write("What is the name of your Goal? ");
                    string name= Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description= Console.ReadLine();
                    Console.Write("What is the amount of point associated with this goal? ");
                    int point= int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target= int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus= int.Parse(Console.ReadLine()); 
                    ChecklistGoal clg= new ChecklistGoal(name, description, point, target, bonus);
                    gList.Add(clg);
                }
            }
            else if (action== "2")
            {
                // list goal
                Console.WriteLine("The goals are:");
                for (int i=0;i<gList.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {gList[i].ItemToAdd()}");
                }
            }
            else if (action== "3")
            {
                // save goal
                Console.Write("Enter a file name you want to save: ");
                string filename= Console.ReadLine();
                using (StreamWriter saveData= new StreamWriter(filename))
                {
                    saveData.WriteLine(score);
                    foreach (Goal item in gList)
                    {
                        if (item is SimpleGoal sg)
                        {
                            saveData.WriteLine($"SimpleGoal,{sg.GetGoalName()},{sg.GetDescription()},{sg.GetPointOfGoal()},{sg.GetIsCompleteStatus()}");
                        }
                        else if (item is EternalGoal eg)
                        {
                            saveData.WriteLine($"EternalGoal,{eg.GetGoalName()},{eg.GetDescription()},{eg.GetPointOfGoal()}");
                        } 
                        else if (item is ChecklistGoal clg)
                        {
                            saveData.WriteLine($"ChecklistGoal,{clg.GetGoalName()},{clg.GetDescription()},{clg.GetPointOfGoal()},{clg.GetBonusPoint()},{clg.GetAmountCompleted()},{clg.GetTarget()}");   
                        }              
                    }
                }
                Console.WriteLine("Saved Successfully!");

            }
            else if (action== "4")
            {
                // load goal
                Console.Write("Enter a file name you want to save: ");
                string filename= Console.ReadLine();
                gList.Clear();
                string[] lines= System.IO.File.ReadAllLines(filename);
                score= int.Parse(lines[0]);
                
                foreach (string line in lines)
                {
                    string[] parts= line.Split(",");
                    string type= parts[0];
                    if (type == "SimpleGoal")
                    {
                        string name= parts[1];
                        string describe= parts[2];
                        int point= int.Parse(parts[3]);
                        bool isComplete= bool.Parse(parts[4]);
                        SimpleGoal sg= new SimpleGoal(name,describe, point);
                        if (isComplete)
                        {
                            sg.markItCompleted();
                        }
                        gList.Add(sg);       
                    }
                    else if (type== "EternalGoal")
                    {
                        string name= parts[1];
                        string describe= parts[2];
                        int point= int.Parse(parts[3]);
                        EternalGoal eg= new EternalGoal(name, describe, point);
                        gList.Add(eg);
                    }
                    else if (type== "ChecklistGoal")
                    {
                        string name= parts[1];
                        string describe= parts[2];
                        int point= int.Parse(parts[3]);
                        int bonus= int.Parse(parts[4]);
                        int completed= int.Parse(parts[5]);
                        int target= int.Parse(parts[6]);
                        ChecklistGoal clg= new ChecklistGoal(name, describe, point, target, bonus);
                        for (int j = 0; j < completed; j++)
                        {
                            clg.RecordCompletion(); ////    
                        }
                        gList.Add(clg);
                    }
                }
                Console.WriteLine("Load Successfully!");
            }

            else if (action== "5")
            {
                // record goal
                Console.WriteLine("The goals are:");
                for (int x=0; x<gList.Count;x++)
                {
                    Console.WriteLine($"{x+1}. {gList[x].GetGoalName()}");
                }
                Console.Write("Which goals did you accomplish? ");
                //int answer= int.Parse(Console.ReadLine()); //
                string answer= Console.ReadLine(); //
                int index; //
                if (int.TryParse(answer, out index) && index > 0 && index <= gList.Count) //
                {
                    Goal accomplishedGoal = gList[index - 1];
                    int earnedPoints = accomplishedGoal.GetPointOfGoal();
                    if (accomplishedGoal is SimpleGoal spg)
                    {
                        spg.markItCompleted();
                        Console.WriteLine($"Congratulation! You have earned {earnedPoints} points!");
                        score+= earnedPoints;
                        Console.WriteLine($"You now have {score} points");
                    }
                    else if (accomplishedGoal is EternalGoal)
                    {
                        Console.WriteLine($"Congratulation! You have earned {earnedPoints} points!");
                        score+= earnedPoints;
                        Console.WriteLine($"You now have {score} points");
                    }
                    else if (accomplishedGoal is ChecklistGoal clg)
                    {
                        clg.RecordCompletion();
                        var completed= clg.GetAmountCompleted();
                        var target= clg.GetTarget();
                        var bonus= clg.GetBonusPoint();
                        if(clg.CompletedTarget()==true)
                        {
                            score+= earnedPoints + bonus;
                            Console.WriteLine($"Amazing! You completed the checklist goal and earned {earnedPoints + bonus} points including bonus!");
                        }
                        else
                        {
                                score += earnedPoints; 
                                Console.WriteLine($"Congratulations! You have earned {earnedPoints} points."); 
                                Console.WriteLine($"Progress: {completed}/{target}"); 
                                Console.WriteLine($"You now have {score} points");
                        }
                    }
                }
            }
        }
    }
}
