using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        List<BaseGoal> goals = LoadGoals("goals.json");
        DisplayScore(goals);
        DisplayGoals(goals);
        CreateNewGoal(goals);
        RecordEvent(goals);
        SaveGoals(goals, "goals.json");
    }

    static void DisplayScore(List<BaseGoal> goals)
    {
        int totalScore = CalculateTotalScore(goals);
        Console.WriteLine($"Total Score: {totalScore}");
    }

    static void DisplayGoals(List<BaseGoal> goals)
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    static void CreateNewGoal(List<BaseGoal> goals)
    {
        Console.WriteLine("Create a New Goal:");
        Console.Write("Enter Goal Name: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter Value: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(goalName, value));
                break;
            case 2:
                goals.Add(new EternalGoal(goalName, value));
                break;
            case 3:
                Console.Write("Enter Total Required: ");
                int totalRequired = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(goalName, value, totalRequired));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent(List<BaseGoal> goals)
    {
        Console.WriteLine("Record Event (Completion of a Goal):");
        Console.WriteLine("Enter the number of the goal you completed:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
        }
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            BaseGoal goal = goals[goalNumber];
            int points = goal.Complete();
            Console.WriteLine($"Completed: {goal.DisplayStatus()}. Gained {points} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static int CalculateTotalScore(List<BaseGoal> goals)
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.GetPoints();
        }
        return totalScore;
    }

    static void SaveGoals(List<BaseGoal> goals, string fileName)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All 
        };
        string json = JsonConvert.SerializeObject(goals, settings);
        File.WriteAllText(fileName, json);
    }

    static List<BaseGoal> LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
            return new List<BaseGoal>();

        string json = File.ReadAllText(fileName);
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };
        return JsonConvert.DeserializeObject<List<BaseGoal>>(json, settings);
    }
}
