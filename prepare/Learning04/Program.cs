using System;
using System.Reflection.PortableExecutable;
namespace Learning04;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-13");
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        WritingAssignment writingAssignment = new("Mary Waters", "European History", "Causes of WWI");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}