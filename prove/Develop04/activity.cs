abstract class Activity {
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }
    public void setDuration(int duration) {
        _duration = duration;
    }
    public void startMessage() {
        Console.WriteLine($"{_name}\n{_description}");
        Thread.Sleep(4000);
        Console.Clear();
    }
    public void endMessage() {
        Console.WriteLine($"Great job!");
        Thread.Sleep(4000);
        Console.WriteLine($"{_name}\nDuration: {_duration} s.");
        Thread.Sleep(4000);
        Console.Clear();
    }
}