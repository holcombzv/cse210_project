public class Quirkle : Game
{
    public Quirkle() : base("Quirkle")
    {

    }
    public override string WriteSave()
    {
        string text = $"{base.GetName()}";
        text += $"\n{base.GetCurrentPlayer().GetName()}";
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
        string currentPlayerName = lines[0];
        lines.RemoveAt(0);
        foreach(string line in lines)
        {
            String[] items = line.Split('|');
            User player = new User(items[0]);
            player.AddPoints(int.Parse(items[1]));
            base.AddUser(player);
            if(player.GetName() == currentPlayerName)
            {
                SetCurrrentPlayer(player);
            }
        }
    }
    public override void Score()
    {
        Console.WriteLine($"How many points did {base.GetCurrentPlayer().GetName()} get? Just press enter to end game.");
        string text = Console.ReadLine();
        if(text == "")
        {
            End();
        }
        else
        {
            int points = int.Parse(text);
            base.GetCurrentPlayer().AddPoints(points);
            base.SetCurrrentPlayer(base.NextPlayer());
        }
    }
    public override void Start()
    {
        base.Start();
        if(base.GetCurrentPlayer().GetName() == "start")
        {
            Console.WriteLine("Who is going first?");
            string name = Console.ReadLine();
            base.SetCurrrentPlayer(base.FindPlayer(name));
        }
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
        Console.Clear();
    }
}