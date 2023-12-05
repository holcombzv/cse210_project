public class Farkle : Game
{
    User _highScore;
    public Farkle() : base("Farkle")
    {
        _highScore = new User("");
    }
    public override string WriteSave()
    {
        string text = $"{base.GetName()}";
        text += $"\n{_highScore.WriteSave()}";
        foreach(User player in base.GetPlayers())
        {
            text += $"\n{player.WriteSave()}";
        }
        return text;
    }
    public override void Load()
    {
        string[] linesRaw = System.IO.File.ReadAllLines(base.GetName());
        List<string> lines = new List<string>();
        foreach(string item in linesRaw)
        {
            lines.Add(item);
        }
        
        String[] items1 = lines[0].Split('|');
        base.SetName(items1[0]);
        lines.RemoveAt(0);
        items1 = lines[0].Split('|');
        _highScore = new User(items1[0]);
        _highScore.AddPoints(int.Parse(items1[1]));
        lines.RemoveAt(0);
        foreach(string line in lines)
        {
            String[] items = line.Split('|');
            User player = new User(items[0]);
            player.AddPoints(int.Parse(items[1]));
            base.AddUser(player);
        }
    }
    public override void End()
    {
        Console.WriteLine($"Game Over!!! {_highScore.GetName()} has earned 10,000 points!\n\nResults:");
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
        if(_highScore.GetPoints() <= 10000)
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