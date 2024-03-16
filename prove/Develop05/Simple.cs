using Microsoft.VisualBasic;

namespace Develop05;

class Simple : Goal
{
    public Simple(string title, string description, int points) : base(title, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Completed simple goal: {Title}");
        return Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nPoints: {Points}");
    }

    public override bool IsCompleted()
    {
        return true;
    }
}