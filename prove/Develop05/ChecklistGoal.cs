using System;

[Serializable]
class ChecklistGoal : BaseGoal
{
    private int completionCount;
    private int totalRequired;

    public ChecklistGoal(string goalName, int value, int totalRequired) : base(goalName, value)
    {
        this.totalRequired = totalRequired;
    }

    public override int Complete()
    {
        completionCount++;
        if (completionCount >= totalRequired)
        {
            return value + 500;
        }
        else
        {
            return value;
        }
    }

    public override string DisplayStatus()
    {
        return $"Checklist Goal: {goalName} - Completed {completionCount}/{totalRequired} times";
    }
}
