using System;

[Serializable]
abstract class BaseGoal
{
    protected string goalName;
    protected int value;

    public BaseGoal(string goalName, int value)
    {
        this.goalName = goalName;
        this.value = value;
    }

    public abstract int Complete();
    public abstract string DisplayStatus();
}
