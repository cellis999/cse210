namespace Develop05;

class Checklist : Goal
{
    public int Completions { get; private set; }
    public int TotalCompletions { get; private set; }

    public Checklist(string title, string description, int points, int totalCompletions, int completions = 0) : base(title, description, points)
    {
        TotalCompletions = totalCompletions;
        Completions = completions;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Recorded event for checklist goal: {Title}");
        Completions++;
        if (Completions >= TotalCompletions)
            return Points + 500;
        else
            return Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nPoints: {Points}");
    }

    public override bool IsCompleted()
    {
        return Completions >= TotalCompletions;
    }
}