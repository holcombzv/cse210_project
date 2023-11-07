public class Listening: Activity {
    private List<string> _prompts;
    private List<string> _responses;
    public Listening(string name, string description,List<string> prompts): base(name, description) {
        _prompts = prompts;
        _responses = new List<string>();
    }
    public override void run() {
        string prompt = getRandom(_prompts);
        // Thread.Sleep(3000);

        int time = startMessage();
        setDuration(time);
        DateTime startTime = DateTime.Now;
        DateTime current = startTime;
        DateTime endTime = startTime.AddSeconds(time);

        while(current < endTime) {
            Console.WriteLine($"{prompt}\n");
            string response = Console.ReadLine();
            _responses.Add($"{response}");
            current = DateTime.Now;
            Console.Clear();
        }

        Console.WriteLine($"{_responses.Count} items entered.");
        Thread.Sleep(3000);
        Console.Clear();
        endMessage();
    }
}