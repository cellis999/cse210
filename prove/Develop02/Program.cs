using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace Develop02;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Random rand = new Random();
                    string[] prompts = {
                        "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"
                    };
                    int randomIndex = rand.Next(prompts.Length);
                    string prompt = prompts[randomIndex];

                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response, DateTime.Now);
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.Clear();
                    break;

                case 5:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
