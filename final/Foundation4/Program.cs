using System;
namespace foundation4;

class Program
{
    static void Main(string[] args)
    {
        Running activity1 = new("4/1/24", 30, 4.8);
        Cycling activity2 = new("4/2/24", 45, 5.6);
        Swimming activity3 = new("4/3/24", 60, 30);

        List<Activity> activities = new();
        activities.Add(activity1);
        activities.Add(activity2);
        activities.Add(activity3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}