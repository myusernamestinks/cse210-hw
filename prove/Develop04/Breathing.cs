using System;

public class Breathing : Activity
{
    public Breathing(int duration) : base(duration)
    {
    }


public override void Run()
{
    StartActivity("Breathing Activity", "This activity will help you relax and clear your mind by focusing on proper breathing techniques.");
    DateTime startTime = DateTime.Now;
    while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
    {
        
        Console.WriteLine("Breathe in...");PauseWithSpinner(5);
        
        Console.WriteLine("Breathe out...");PauseWithSpinner(5);
        
    }
    EndActivity("Breathing Activity");
}
}