using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Genesis", 12, 1, 5);
        List<int> verse = ref1.getVerses();
        foreach (int item in verse) {
            Console.WriteLine($"{item}");
        }
    }
}