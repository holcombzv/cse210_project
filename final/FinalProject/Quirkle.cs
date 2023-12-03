public class Quirkle : Game
{
    private User _currentPlayer;
    public Quirkle() : base("Qwirkle")
    {

    }
    public override void Score()
    {
        Console.WriteLine($"How many points did {_currentPlayer.GetName()} get?");
        int points = int.Parse(Console.ReadLine());
        _currentPlayer.AddPoints(points);
    }
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Who is going first?");
        string name = Console.ReadLine();
        _currentPlayer = base.FindPlayer(name);
        Console.Clear();
        while(true)
        {
            Score();
            Console.WriteLine("If the game is over, type \"End\". Otherwise, just press Enter.");
            if(Console.ReadLine() == "End")
            {
                Console.Clear();
                End();
            }
            _currentPlayer = NextPlayer();
            Console.Clear();
        }
    }
    public override void End()
    {
        List<User> sortedPlayers = base.getPlayers().OrderByDescending(player => player.GetPoints()).ToList();
        int n = 1;
        Console.WriteLine("Results:");
        foreach(User player in sortedPlayers)
        {
            Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
            n++;
        }
        System.Environment.Exit(0);
    }
}