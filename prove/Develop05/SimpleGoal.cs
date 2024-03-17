using System;

[Serializable]
class SimpleGoal : BaseGoal
{
    public SimpleGoal(string goalName, int value) : base(goalName, value)
    {
    }

    public override int Complete()
    {
        return value;
    }

    public override string DisplayStatus()
    {
        return "Simple Goal: " + goalName;
    }
}
