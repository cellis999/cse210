using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
namespace Develop05;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int points = 0;

    static void Main(string[] args)
    {
        LoadGoals();

        bool loopBreak = false;

        while (!loopBreak)
        {
            Console.WriteLine($"You have {points} points\n");
            Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Record Event\n   4. Save Goals\n   5. Load Goals\n   6. Quit");
            Console.Write("Enter a number to select an option: ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    SaveGoals();
                    break;
                case 5:
                    LoadGoals();
                    break;
                case 6:
                    loopBreak = true;
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("Choose Goal Type:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
        Console.Write("Enter the number for the type of goal you want to create: ");
        int goalType = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                Console.Write("Enter goal title: ");
                string title = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter points for completing the goal: ");
                int pointsValue = int.Parse(Console.ReadLine());
                goals.Add(new Simple(title, description, pointsValue));
                break;
            case 2:
                Console.Write("Enter goal title: ");
                string eternalTitle = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Enter points for each time you record the event: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goals.Add(new Eternal(eternalTitle, eternalDescription, eternalPoints));
                break;
            case 3:
                Console.Write("Enter goal title: ");
                string checklistTitle = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string checklistDescription = Console.ReadLine();
                Console.Write("Enter points for each time you record the event: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter total completions required: ");
                int totalCompletions = int.Parse(Console.ReadLine());
                goals.Add(new Checklist(checklistTitle, checklistDescription, checklistPoints, totalCompletions));
                break;
        }
    }

    static void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            Console.WriteLine("List of Goals:");
            foreach (var goal in goals)
            {
                Console.Write("[");
                if (goal.IsCompleted())
                    Console.Write("X");
                else
                    Console.Write(" ");
                Console.Write("] ");
                goal.DisplayGoal();
                if (goal is Checklist checklist)
                {
                    Console.WriteLine($"Completed: {checklist.Completions}/{checklist.TotalCompletions}");
                }
                Console.WriteLine();
            }
        }
    }

    static void RecordEvent()
    {
        Console.Write("Enter the number of the goal you've completed: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            points += goal.RecordEvent();
            Console.WriteLine($"Event recorded for goal: {goal.Title}. You earned {goal.Points} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Title);
                writer.WriteLine(goal.Description);
                writer.WriteLine(goal.Points);
                writer.WriteLine(goal is Checklist ? ((Checklist)goal).Completions : -1);
                writer.WriteLine(goal is Checklist ? ((Checklist)goal).TotalCompletions : -1);
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        goals.Clear();
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string type = reader.ReadLine();
                    string title = reader.ReadLine();
                    string description = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());
                    int completions = int.Parse(reader.ReadLine());
                    int totalCompletions = int.Parse(reader.ReadLine());

                    switch (type)
                    {
                        case nameof(Simple):
                            goals.Add(new Simple(title, description, points));
                            break;
                        case nameof(Eternal):
                            goals.Add(new Eternal(title, description, points));
                            break;
                        case nameof(Checklist):
                            goals.Add(new Checklist(title, description, points, totalCompletions, completions));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}