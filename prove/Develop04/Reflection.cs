namespace Develop04;

class ReflectionActivity : IActivity
{
    private int time;

    public ReflectionActivity()
    {
    }

    public void PerformActivity()
    {
        Random random = new Random();

        while (time > 0)
        {
            List<string> prompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Activity.PauseAnimation();

            List<string> reflectionQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Activity.PauseAnimation();
            }

            time -= reflectionQuestions.Count * 5;
        }
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        time = int.Parse(Console.ReadLine());
    }
}