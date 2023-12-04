public class Farkle : Game
{
    User highScore;
    public Farkle() : base("Farkle")
    {

    }
    public override void End()
    {
        Console.WriteLine($"Game Over!!! {highScore.GetName()} has earned 10,000 points!\n\nResults:");
        List<User> sortedPlayers = base.GetPlayers().OrderBy(player => player.GetPoints()).ToList();
        int n = 1;
        foreach(User player in sortedPlayers)
        {
            Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
            n ++;
        }
        Console.WriteLine("\nPress Enter to end");
        Console.ReadLine();
        Console.Clear();
        System.Environment.Exit(0);
    }
    public override void Score()
    {
        Console.WriteLine($"How many points did {base.GetCurrentPlayer().GetName()} earn?");
        int points = int.Parse(Console.ReadLine());
        base.GetCurrentPlayer().AddPoints(points);
        base.SetCurrrentPlayer(base.NextPlayer());
        Console.Clear();
    }
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Roll to see who goes first");
        Console.ReadLine();
        Console.WriteLine("\nWho is going first?");
        string firstPlayer = Console.ReadLine();
        User currentPlayer = base.FindPlayer(firstPlayer);
        base.SetCurrrentPlayer(currentPlayer);
        Console.Clear();
    }
    public override void RunRound()
    {
        if(highScore.GetPoints() <= 10000)
        {
            for(int n = 1; n <= base.GetPlayers().Count(); n ++)
            {
                Score();
            }
        }
        else
        {
            for(int n = 1; n <= base.GetPlayers().Count(); n ++)
            {
                Score();
            }
            End();
        }
    }
}