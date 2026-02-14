using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }

    public override string ItemToAdd()
    {
        return $"[ ] {GetGoalName()} ({GetDescription()})";
    }
}