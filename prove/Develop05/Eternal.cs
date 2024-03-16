namespace Develop05;

class Eternal : Goal
{
    public Eternal(string title, string description, int points) : base(title, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Recorded event for eternal goal: {Title}");
        return Points;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nPoints: {Points}");
    }

    public override bool IsCompleted()
    {
        return false;
    }
}