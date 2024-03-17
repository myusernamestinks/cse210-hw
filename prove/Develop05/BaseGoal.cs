using System;

[Serializable]
abstract class BaseGoal
{
    protected string goalName;
    protected int value;
    protected int timesCompleted; 
    protected int totalPoints; 

    public BaseGoal(string goalName, int value)
    {
        this.goalName = goalName;
        this.value = value;
        timesCompleted = 0; 
        totalPoints = 0; 
    }

    public abstract int Complete();
    public abstract string DisplayStatus();

    
    public int GetPoints()
    {
        return totalPoints;
    }
}
