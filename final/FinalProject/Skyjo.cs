public class Skyjo : Game
{
    private User highScore;
    public Skyjo() : base("Skyjo")
    {
        highScore = new User("");
    }
    public override void End()
    {
        Console.WriteLine($"Game Over!!! {highScore.GetName()} has earned 100 points!\n\nResults:");
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
            Console.WriteLine($"How many points did {player.GetName()} get?");
            int points = int.Parse(Console.ReadLine());
            player.AddPoints(points);
            Console.Clear();
        }
    }
    public override void Start()
    {
        base.Start();
    }
    public override void RunRound()
    {
        if(highScore.GetPoints() < 100)
            {
                Score();
                Console.WriteLine("Current totals:");
                List<User> sortedPlayers = base.GetPlayers().OrderBy(player => player.GetPoints()).ToList();
                int n = 1;
                foreach(User player in sortedPlayers)
                {
                    if(player.GetPoints() > highScore.GetPoints())
                    {
                        highScore = player;
                    }
                    Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
                    n ++;
                }
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                End();
            }
    }
}