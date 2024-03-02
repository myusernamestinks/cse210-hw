using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> reflectionPrompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever  done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this  experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(int duration) : base(duration)
    {
    }


    public override void Run()
    {
        StartActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        DateTime startTime = DateTime.Now;
        TimeSpan activityDuration = TimeSpan.FromSeconds(duration);

        while (DateTime.Now - startTime < activityDuration)
        {
            Random random = new Random();
            string prompt = reflectionPrompts[random.Next(reflectionPrompts.Count)];
            Console.WriteLine(prompt);
            PauseWithSpinner(8);

            if (DateTime.Now - startTime >= activityDuration)
                break; 

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(8);

                
                if (DateTime.Now - startTime >= activityDuration)
                    break; 
            }
        }
        EndActivity("Reflection Activity");
    }

}