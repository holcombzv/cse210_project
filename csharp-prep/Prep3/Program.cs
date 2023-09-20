using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt user for "magic number"
        Console.WriteLine("What is the magic number?");
        int magNum = int.Parse(Console.ReadLine());

        //Prompt the user for guesses until they guess correctly
        bool correct = false;
        while (!correct)
        {
            Console.WriteLine("\nWhat is your guess?");
            int guess = int.Parse(Console.ReadLine());

            if (guess > magNum)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magNum)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                correct = true;
            }
        }

        Console.WriteLine("Congratulations! You guessed right");
    }
}