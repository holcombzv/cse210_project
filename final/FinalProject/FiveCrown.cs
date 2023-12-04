public class FiveCrown : Game
{
    int _round;
    int _roundMax = 11;
    public FiveCrown() : base("FiveCrown")
    {
        _round = 1;
        _roundMax = 11;
    }
    public override void End()
    {
        Console.WriteLine($"Game Over!!!");
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
        foreach(User player in base.GetPlayers())
        {
            Console.WriteLine($"How many points did {player.GetName()} earn?");
            player.AddPoints(int.Parse(Console.ReadLine()));
            Console.Clear();
        }
    }
    public override void Start()
    {
        base.Start();
        Console.WriteLine("How many rounds will you be playing?");
        _roundMax = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    public override void RunRound()
    {
        if(_round <= _roundMax)
            {
                Score();
                Console.WriteLine($"Round {_round} totals:");
                int n = 1;
                foreach(User player in base.GetPlayers())
                {
                    Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                End();
            }
    }
}