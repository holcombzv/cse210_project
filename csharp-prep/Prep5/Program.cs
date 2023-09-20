using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            //Displays a welcome message for the user
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            //Prompts the user to enter their name
            string name;
            Console.WriteLine("\nPlease enter your name: ");
            name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            //Prompt the user for a number
            Console.WriteLine("\nPlease enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int num)
        {
            //Squares the number "num" and returns it.
            int squared = num * num;
            return squared;
        }

        static void DisplayResult(string name, int num)
        {
            //Displays results
            Console.WriteLine($"\n{name}, your number squared is: {num}");
        }

        DisplayWelcome();
        string  name = PromptUserName();
        int userNum = PromptUserNumber();
        int newNum = SquareNumber(userNum);
        DisplayResult(name, newNum);
    }
}