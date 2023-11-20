using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        menu.login();
        while(true) {
            menu.select();
            menu.runSelection();
        }
    }
}