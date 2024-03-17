using System;

[Serializable]
class EternalGoal : BaseGoal
{
    private int timesCompleted; 

    public EternalGoal(string goalName, int value) : base(goalName, value)
    {
        timesCompleted = 0;
    }
    public override int Complete()
    {
        timesCompleted++;
        return value;
    }

    public override string DisplayStatus()
    {
        return $"Eternal Goal: {goalName} - Completed {timesCompleted} times";
    }
}
