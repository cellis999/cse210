using System.Runtime.CompilerServices;

namespace Develop04;


interface IActivity
{
    void PerformActivity();
}

class Activity
{
    protected int time;
    protected string activityName;
    protected string description;

    public Activity(string activityName, string description)
    {
        this.activityName = activityName;
        this.description = description;
    }

    public void Prompt()
    {
        Console.Write($"{activityName}\n\n{description}");
    }

    public static void PauseAnimation()
    {
        List<string> characters = new List<string> { "|", "/", "-", "\\" };
        for (int i = 3; i > 0; i--)
        {
            foreach (string item in characters)
            {
                Console.Write(item);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }
        }
    }

    public void PerformActivity(IActivity specificActivity)
    {
        Prompt();
        PrepareForActivity();

        specificActivity.PerformActivity();

        ConcludeActivity();
    }

    private void PrepareForActivity()
    {
        Console.WriteLine("\nPrepare to begin...\n");
        PauseAnimation();
    }

    private void ConcludeActivity()
    {
        Console.WriteLine($"\n\nGood job! You have completed the {activityName}.");
        PauseAnimation();
    }
}
