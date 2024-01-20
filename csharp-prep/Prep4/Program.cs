using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        int sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        while (done == false)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            if (number == 0)
            {
                done = true;
            }
        }
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        float average = sum / (numbers.Count - 1);
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}