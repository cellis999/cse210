namespace Develop04;

class ListingActivity : IActivity
{
    private int time;

    public ListingActivity()
    {
    }

    public void PerformActivity()
    {
        Random random = new Random();
        List<string> prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Activity.PauseAnimation();

        Console.WriteLine($"You have {time} seconds to begin thinking about the prompt.\n");
        Activity.PauseAnimation();

        DateTime startTime = DateTime.Now;
        List<string> items = new List<string>();
        // Allow the user to list items until the specified duration is reached
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(time))
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nNumber of items entered: {items.Count}");
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        time = int.Parse(Console.ReadLine());
    }
}