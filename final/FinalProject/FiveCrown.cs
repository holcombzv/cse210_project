public class FiveCrown : Game
{
    int _round;
    public FiveCrown(string name) : base(name)
    {
        _round = 1;
    }
    public override void End()
    {
        Console.WriteLine($"Game Over!!!");
        List<User> sortedPlayers = base.getPlayers().OrderBy(player => player.GetPoints()).ToList();
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
        foreach(User player in base.getPlayers())
        {
            Console.WriteLine($"How many points did {player.GetName()} earn?");
            player.AddPoints(int.Parse(Console.ReadLine()));
            Console.Clear();
        }
    }
    public override void Start()
    {
        base.Start();
        _round = 1;
        while(true)
        {
            if(_round <= 11)
            {
                Score();
                Console.WriteLine($"Round {_round} totals:");
                int n = 1;
                foreach(User player in base.getPlayers())
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
}