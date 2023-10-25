using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Zach", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Zach", "Statistics", "10.4", "7-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writ1 = new WritingAssignment("Zach", "Everything", "A Brief History of the Universe");
        Console.WriteLine($"{writ1.GetSummary()}");
        Console.WriteLine($"{writ1.GetWritinginformation()}");
    }
}