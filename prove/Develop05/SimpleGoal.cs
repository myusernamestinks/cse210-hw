using System;

[Serializable]
class SimpleGoal : BaseGoal
{
    public SimpleGoal(string goalName, int value) : base(goalName, value)
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
        return $"Simple Goal: {goalName} - Completed {timesCompleted} times";
    }
}
