using System;

public abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    
    public virtual void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        PauseWithSpinner(6);
    }

  
    public virtual void EndActivity(string activityName)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {activityName} for {duration} seconds");
        PauseWithSpinner(6);
        Console.WriteLine($"{activityName} completed!");
    }

    
protected void PauseWithSpinner(int duration)
{
    int initialLeft = Console.CursorLeft;
    int initialTop = Console.CursorTop;

    for (int i = duration; i > 0; i--)
    {
        Console.Write($"[{i}]");
        System.Threading.Thread.Sleep(1000);

        if (initialLeft + 4 >= Console.BufferWidth)
        {
            
            Console.SetCursorPosition(0, Console.CursorTop + 1);
        }
        else
        {
            Console.SetCursorPosition(initialLeft, initialTop);
        }
    }
    Console.WriteLine();
}


   
    public abstract void Run();
}