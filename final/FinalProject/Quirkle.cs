public class Quirkle : Game
{
    public Quirkle() : base("Qwirkle")
    {

    }
    public override void Score()
    {
        Console.WriteLine($"How many points did {base.GetCurrentPlayer().GetName()} get?");
        int points = int.Parse(Console.ReadLine());
        base.GetCurrentPlayer().AddPoints(points);
    }
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Who is going first?");
        string name = Console.ReadLine();
        base.SetCurrrentPlayer(base.FindPlayer(name));
        Console.Clear();
    }
    public override void End()
    {
        List<User> sortedPlayers = base.GetPlayers().OrderByDescending(player => player.GetPoints()).ToList();
        int n = 1;
        Console.WriteLine("Results:");
        foreach(User player in sortedPlayers)
        {
            Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
            n++;
        }
        System.Environment.Exit(0);
    }
    public override void RunRound()
    {
        Score();
            Console.WriteLine("If the game is over, type \"End\". Otherwise, just press Enter.");
            if(Console.ReadLine() == "End")
            {
                Console.Clear();
                End();
            }
            base.SetCurrrentPlayer(base.NextPlayer());
            Console.Clear();
    }
}