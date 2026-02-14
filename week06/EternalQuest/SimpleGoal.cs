using System;

public class SimpleGoal : Goal
{
    private bool _isComplete= false;
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        
    }
    public void markItCompleted()
    {
        _isComplete= true;
    }

    public bool GetIsCompleteStatus() //
    {
        return _isComplete;
    }
    public override string ItemToAdd()
    {
        if (_isComplete==false)
        {
            return $"[ ] {GetGoalName()} ({GetDescription()})";
        }
        else
        {
            return $"[x] {GetGoalName()} ({GetDescription()})";
        }
    }
    // public string SaveSimpleGoal()
    // {
    //     return $""
    // }
}