using System;

[Serializable]
class EternalGoal : BaseGoal
{
    public EternalGoal(string goalName, int value) : base(goalName, value)
    {
    }
    
    public override int Complete()
    {
        timesCompleted++; 
        totalPoints += value; 
        return value; 
    }

    public override string DisplayStatus()
    {
        return $"Eternal Goal: {goalName} - Completed {timesCompleted} times";
    }
}
