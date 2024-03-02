using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> listingPrompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(int duration) : base(duration)
    {
    }

    
    public override void Run()
    {
        StartActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Count)];
        Console.WriteLine(prompt);
        PauseWithSpinner(6);
        Console.WriteLine("Begin listing items...");
        List<string> itemsList = new List<string>();
        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "exit")
                break;
            itemsList.Add(item);
        }
        Console.WriteLine($"Number of items listed: {itemsList.Count}");
        EndActivity("Listing Activity");
    }
}