public class Reflection: Activity {
    public List<string> _prompts;
    public List<string> _questions;
    public Reflection(string name, string description, List<string> prompts, List<string> questions): base(name, description) {
        _prompts = prompts;
        _questions = questions;
    }
    private string getRandom(List<string> list) {
        var random = new Random();
        int index = random.Next(list.Count);
        return list[index];
    }
    public void run() {
        int waitTime = 10;
        string prompt = getRandom(_prompts);

        int time = base.startMessage();
        base.setDuration(time);
        Console.WriteLine(prompt);
        Thread.Sleep(3000);
        time -= 3; // Adjusting for the start time with just the prompt.
        Console.Clear();
        while(time > 0) {
            string question = getRandom(_questions);
            string message = $"{prompt}\n\n{question}";
            // Thread.Sleep(1000);
            base.pause(waitTime - 1, message);
            time -= waitTime;
        }
    }
}