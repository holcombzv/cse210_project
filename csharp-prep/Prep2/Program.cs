using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt user for score
        Console.WriteLine("What is your score?");
        int score = int.Parse(Console.ReadLine());

        //If statements determine which letter grade to assign and whether the user passed or failed
        string letter = "";
        bool passed = false;

        if (score >= 90)
        {
            letter = "A";
            passed = true;
        }

        else if (score >= 80)
        {
            letter = "B";
            passed = true;
        }

        else if (score >= 70)
        {
            letter = "C";
            passed = true;
        }

        else if (score >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        //Display letter grade earned
        Console.WriteLine($"Your earned a {letter}.");
        if (passed)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("You didn't pass. Better luck next time.");
        }

    }
}