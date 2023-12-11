public class FiveCrown : Game
{
    int _round;
    int _roundMax;
    public FiveCrown() : base("FiveCrown")
    {
        _round = 0;
        _roundMax = 11;
    }
    public override string WriteSave()
    {
        string text = $"{base.GetName()}|{_round}|{_roundMax}";
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
        _round = int.Parse(items1[1]);
        _roundMax = int.Parse(items1[2]);
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
        if(_round == 0)
        {
            Console.WriteLine("How many rounds will you be playing? Press Enter for default 11");
            string roundMax =Console.ReadLine();
            if(roundMax != "")
            {
                _roundMax = int.Parse(roundMax);
            }
            _round = 1;
        }
        Console.Clear();
    }
    public override void RunRound()
    {
        Score();
        if(_round < _roundMax)
        {
            Console.WriteLine($"Round {_round} totals:");
            List<User> sortedPlayers = base.GetPlayers().OrderBy(player => player.GetPoints()).ToList();
            int n = 1;
            foreach(User player in sortedPlayers)
            {
                Console.WriteLine($"{n}. {player.GetName()} {player.GetPoints()}");
                n ++;
            }
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        else
        {
            End();
        }
        _round ++;
    }
}