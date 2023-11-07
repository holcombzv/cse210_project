public abstract class Activity {
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
    public string getName() {
        return _name;
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
    public void pauseAnimated(int count, string caption = "") {
        DateTime startTime = DateTime.Now;
        DateTime current = startTime;
        DateTime endTime = startTime.AddSeconds(count);
        Console.WriteLine(caption);
        int pauseTime = 300;
        while(current < endTime) {
            Console.Write("\b+");
            Thread.Sleep(pauseTime);
            Console.Write("\bx");
            Thread.Sleep(pauseTime);
            current = DateTime.Now;
        }
        Console.Clear();
    }
    public string getRandom(List<string> list) {
        var random = new Random();
        int index = random.Next(list.Count);
        return list[index];
    }
    public int startMessage() {
        // Prints a start message to the user in the console and calls the pause function
        Console.WriteLine($"{_name}\n{_description}\n\nWhat is the duration(sec.):");
        int duration = int.Parse(Console.ReadLine());
        pause(3);
        Console.Clear();
        return duration;
    }
    public void endMessage() {
        // Prints an end message to the user in the console and calls the pause function
        Console.WriteLine($"Great job!");
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine($"{_name}\nDuration: {_duration} s.");
        Thread.Sleep(4000);
        Console.Clear();
    }
    public abstract void run();
}