public class Listening: Activity {
    private List<string> _prompts;
    private List<string> _responses;
    public Listening(string name, string description,List<string> prompts): base(name, description) {
        _prompts = prompts;
    }
    public void run() {
        string prompt = getRandom(_prompts);
        // Thread.Sleep(3000);

        int time = startMessage();
        DateTime startTime = DateTime.Now;
        DateTime current = startTime;
        DateTime endTime = startTime.AddSeconds(time);

        while(current < endTime) {
            Console.WriteLine($"{prompt}\n");
            string response = Console.ReadLine();
            _responses.Add(response);
            current = DateTime.Now;
            Console.Clear();
        }
        endMessage();
    }
}