using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = null;
        string passClass = null;
        Console.Write("Enter Grade Percent: ");
        string gradePercentText = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentText);

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent < 90 && gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent < 80 && gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent < 70 && gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercent >= 70)
        {
            passClass = "You pass the class!";
        }
        else
        {
            passClass = "Try again next semester.";
        }
        Console.WriteLine($"{letter}");
        Console.Write($"{passClass}");
    }
}