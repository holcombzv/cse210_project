public class Menu
{
    private List<string> _options;
    private Game _game = new Quirkle();
    private FileHandler _fileHandler = new FileHandler();
    public Menu()
    {
        _options = new List<string> {"Add Player", "Start New Game", "Load Game", "Exit"};
    }
    public int Select()
    {
        Console.WriteLine("Select one:\n");
        Display();
        int selection = int.Parse(Console.ReadLine());
        Console.Clear();
        return selection;
    }
    public void runSelection(int selection)
    {
        int index = selection - 1;
        switch(index)
        {
            case 0:
                Console.WriteLine("What is the new player's name?");
                string name = Console.ReadLine();
                User newPlayer = new User(name);
                _game.AddUser(newPlayer);
                break;
            
            case 1:
                int game = SelectGame();
                switch(game)
                {
                    case 1:
                        List<User> usersFark = _game.GetPlayers();
                        _game = new Farkle();
                        foreach(User user in usersFark)
                        {
                            _game.AddUser(user);
                        }
                        break;
                    
                    case 2:
                        List<User> usersSkyj = _game.GetPlayers();
                        _game = new Skyjo();
                        foreach(User user in usersSkyj)
                        {
                            _game.AddUser(user);
                        }
                        break;
                    
                    case 3:
                        List<User> usersFive = _game.GetPlayers();
                        _game = new FiveCrown();
                        foreach(User user in usersFive)
                        {
                            _game.AddUser(user);
                        }
                        break;
                    
                    case 4:
                        List<User> usersQuir = _game.GetPlayers();
                        _game = new Quirkle();
                        foreach(User user in usersQuir)
                        {
                            _game.AddUser(user);
                        }
                        break;
                }
                Run();
                break;
            
            case 2:
                int loadGame = SelectGame();
                LoadGame(loadGame);
                Run();
                break;
            case 3:
                System.Environment.Exit(0);
                break;
        }
    }
    public void Run()
    {
        _game.Start();
        _fileHandler.SetGame(_game);
        _fileHandler.Save();
        while(true)
        {
            _game.RunRound();
            _fileHandler.Save();
        }
    }
    public void Display()
    {
        int n = 1;
        foreach(string option in _options)
        {
            Console.WriteLine($"{n}. {option}");
            n ++;
        }
    }
    public int SelectGame()
    {
        List<string> games = new List<string> {"Farkle", "Skyjo", "FiveCrown", "Quirkle"};
        Console.WriteLine("Which game do you want to play?\n");
        int n = 1;
        foreach(string game in games)
        {
            Console.WriteLine($"{n}. {game}");
            n ++;
        }
        int selection = int.Parse(Console.ReadLine());
        Console.Clear();
        return selection;
    }
    public void LoadGame(int game)
    {
        switch(game)
        {
            case 1:
                _game = new Farkle();
                _game.Load();
                break;

            case 2:
                _game = new Skyjo();
                _game.Load();
                break;

            case 3:
                _game = new FiveCrown();
                _game.Load();
                break;

            case 4:
                _game = new Quirkle();
                _game.Load();
                break;
        }
    }
}