using System;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Skyjo();
        game.AddUser(new User("Zach"));
        game.AddUser(new User("Kate"));
        Console.Clear();
        game.Start();
    }
}