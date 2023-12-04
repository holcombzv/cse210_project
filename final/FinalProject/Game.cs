public abstract class Game
{
    private string _name;
    private List<User> _players = new List<User>();
    private User _currentPlayer;
    public Game(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public List<User> GetPlayers()
    {
        return _players;
    }
    public User GetCurrentPlayer()
    {
        return _currentPlayer;
    }
    public void SetCurrrentPlayer(User player)
    {
        _currentPlayer = player;
    }
    public void AddUser(User newPlayer)
    {
        _players.Add(newPlayer);
    }
    public abstract void Score();
    public virtual void Start()
    {
        if(_players.Count() < 1)
        {
            Console.WriteLine("Please add players before starting game.");
            System.Environment.Exit(0);
        }
        _currentPlayer = _players[0];
    }
    public abstract void End();
    public User FindPlayer(string name)
    {
        User namedPlayer = new User("");
        foreach(User player in _players)
        {
            if(name == player.GetName())
            {
                namedPlayer = player;
            }
        }
        return namedPlayer;
    }
    public User NextPlayer()
    {
        int index = _players.IndexOf(_currentPlayer);
        if(index >= _players.Count() - 1)
        {
            index = 0;
        }
        else
        {
            index ++;
        }
        return _players[index];
    }
}