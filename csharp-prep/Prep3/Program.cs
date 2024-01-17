using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool numberGuessed = false;

        while (numberGuessed == false)
        {
            Console.Write("What is your guess? ");
            string readGuess = Console.ReadLine();
            int guess = int.Parse(readGuess);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                numberGuessed = true;
            }
        }

    }
}