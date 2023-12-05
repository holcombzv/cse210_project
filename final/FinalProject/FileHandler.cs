public class FileHandler
{
    private Game _game;
    public FileHandler()
    {

    }
    public void SetGame(Game game)
    {
        _game = game;
    }
    public void Save()
    {
        File.WriteAllText(_game.GetName(), "");
        using(StreamWriter file = new StreamWriter(_game.GetName()))
        {
            file.WriteLine(_game.WriteSave());
            file.Close();
        }
    }
    public Game Load()
    {
        _game.Load();
        return _game;
    }
}