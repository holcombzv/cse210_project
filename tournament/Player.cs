public class Player
{
    private string _name;
    private int _number;

    public Player(string name, int number)
    {
        //Constructor
        _name = name;
        _number = number;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} {_number}");
    }
}