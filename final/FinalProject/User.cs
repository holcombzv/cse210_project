public class User
{
    private string _name;
    private int _points;
    public User(string name)
    {
        _name = name;
        _points = 0;
    }
    public string GetName() 
    {
        return _name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void AddPoints(int points)
    {
        _points += points;
    }
}