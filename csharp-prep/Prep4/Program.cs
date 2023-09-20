using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt the user for numbers to save in a list until 0 is entered
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List <int> numbers = new List<int>();
        do
        {
            Console.Write("Enter whole number: ");
            int newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        } while (newNum != 0);
    }
}