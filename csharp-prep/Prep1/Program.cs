using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt user for first name
        Console.WriteLine("What is your first name?");
        string fname = Console.ReadLine();

        //Prompt user for last name
        Console.WriteLine("What is your last name? ");
        string lname = Console.ReadLine();

        //Display name in James Bond style
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}