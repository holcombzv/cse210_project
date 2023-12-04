using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while(true)
        {
            Console.Clear();
            menu.runSelection(menu.Select());
        }
    }
}