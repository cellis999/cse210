using Microsoft.VisualBasic;
using System.IO;
using System.Runtime.InteropServices;

namespace Develop05;
abstract class Goal
{
    public string Title { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }

    public Goal(string title, string description, int points)
    {
        Title = title;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract void DisplayGoal();
    public abstract bool IsCompleted();
}