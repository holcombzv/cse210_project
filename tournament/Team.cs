public class Team
{
    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        //Constructor
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        //Adds player object to team
        _roster.Add(p);
    }

    public void AddWin()
    {
        //Adds win to team
        _wins ++;
    }

    public void AddLoss()
    {
        //Adds loss to team
        _losses ++;
    }

    public void DisplayRoster()
    {
        //Displays team variables to Console
        Console.WriteLine($"\n{_name}");
        Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();
    }

    public string GetTeamName()
    {
        return _name;
    }
}