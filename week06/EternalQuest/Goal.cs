using System;

public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _point;

    public Goal(string name, string description, int point)
    {
        _goalName= name;
        _description= description;
        _point= point;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointOfGoal()
    {
        return _point;
    }
    public abstract string ItemToAdd(); // Abstract class must be overwritten in all the child classes
}