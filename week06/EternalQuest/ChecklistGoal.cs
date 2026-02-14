using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted=0;
    private int _target;//
    private int _bonus;//
    public ChecklistGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target=target;
        _bonus= bonus;
    }

    public int GetTarget()
    {
        return _target;
    }
    public int GetBonusPoint()
    {
        return _bonus;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public override string ItemToAdd()
    {
        if (CompletedTarget()==false)
        {
            return $"[ ] {GetGoalName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[x] {GetGoalName()} ({GetDescription()}) -- Target completed: {_amountCompleted}/{_target}";
        }
    }

    public bool CompletedTarget()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int RecordCompletion() 
    { 
        return _amountCompleted++; 
    }
}