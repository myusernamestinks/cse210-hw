using System;

[Serializable]
class ChecklistGoal : BaseGoal
{
    private int totalRequired;

    public ChecklistGoal(string goalName, int value, int totalRequired) : base(goalName, value)
    {
        this.totalRequired = totalRequired;
    }

    public override int Complete()
    {
        timesCompleted++; 
        totalPoints += value; 
        if (timesCompleted >= totalRequired)
        {
            totalPoints += 500; 
            return value + 500; 
        }
        else
        {
            return value;
        }
    }

    public override string DisplayStatus()
    {
        return $"Checklist Goal: {goalName} - Completed {timesCompleted}/{totalRequired} times";
    }
}

