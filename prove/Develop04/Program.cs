using System;
using System.Globalization;
namespace Develop04;

class Program
{
    static void Main(string[] args)
    {
        bool toggle = true;

        while (toggle)
        {
            Console.WriteLine("Menu Options:\n   1. Breathing Activity\n   2. Reflection Activity\n   3. Listing Activity\n   4. Quit");
            Console.Write("Select an option from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.SetDuration();
                        Console.Clear();
                        new Activity("Breathing Activity", "").PerformActivity(breathingActivity);
                        break;

                    case 2:
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.SetDuration();
                        Console.Clear();
                        new Activity("Reflection Activity", "").PerformActivity(reflectionActivity);
                        break;

                    case 3:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.SetDuration();
                        Console.Clear();
                        new Activity("Listing Activity", "").PerformActivity(listingActivity);
                        break;

                    case 4:
                        toggle = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.Clear();
        }
    }
}