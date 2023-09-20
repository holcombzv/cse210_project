using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt the user for numbers to save in a list until 0 is entered
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List <int> numbers = new List<int>();
        int newNum = 0;
        do
        {
            Console.Write("Enter whole number: ");
            newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        } while (newNum != 0);

        //Calculate and display the sum, average, and max values
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double mean = numbers.Average();
        Console.WriteLine($"The average is: {mean}");

        int max = numbers.Max();
        Console.WriteLine($"The max value is: {max}");
    }
}