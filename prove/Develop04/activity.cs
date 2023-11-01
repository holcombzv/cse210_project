public class Activity {
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
    public void pause(int count, string caption = "") {
        // Pauses and displays an animation in the console for every second indicated in count
        for(int i = count; i >= 1; i --) {
            Console.Clear();
            Console.WriteLine(caption);
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
    public int startMessage() {
        // Prints a start message to the user in the console and calls the pause function
        Console.WriteLine($"{_name}\n{_description}\n\nWhat is the duration(sec.):");
        int duration = int.Parse(Console.ReadLine());
        pause(4);
        Console.Clear();
        return duration;
    }
    public void endMessage() {
        // Prints an end message to the user in the console and calls the pause function
        Console.WriteLine($"Great job!");
        Thread.Sleep(1500);
        Console.WriteLine($"{_name}\nDuration: {_duration} s.");
        Thread.Sleep(4000);
        Console.Clear();
    }
}