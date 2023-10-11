public class Book {
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author) {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }
    public void display() {
        Console.WriteLine($"{_name} by {_author}\nTimes Read: {_timesRead}\nAvailable: {_available}");
    }
    public bool isAvailable() {
        return _available;
    }
    public int timesRead() {
        return _timesRead;
    }
    public void checkOut() {
        _available = false;
        _timesRead += 1;
    }
    public void checkIn() {
        _available = true;
    }
    public bool hasAuthor(string author) {
        return _author.Contains(author);
    }
}