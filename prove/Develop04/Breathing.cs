namespace Develop04;

class BreathingActivity : IActivity
{
    private int time;

    public BreathingActivity()
    {
    }

    public void PerformActivity()
    {
        while (time > 0)
        {
            Console.WriteLine("Breathe in...");
            Activity.PauseAnimation();

            Console.WriteLine("Breathe out...");
            Activity.PauseAnimation();

            time -= 5;
        }
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        time = int.Parse(Console.ReadLine());
    }
}