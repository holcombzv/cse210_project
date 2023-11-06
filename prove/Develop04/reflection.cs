public class Reflection: Activity {
    private List<string> _prompts;
    private List<string> _questions;
    public Reflection(string name, string description, List<string> prompts, List<string> questions): base(name, description) {
        _prompts = prompts;
        _questions = questions;
    }
    public override void run() {
        int waitTime = 10;
        string prompt = getRandom(_prompts);

        int time = base.startMessage();
        setDuration(time);
        Console.WriteLine(prompt);
        Thread.Sleep(3000);
        time -= 3; // Adjusting for the start time with just the prompt.
        Console.Clear();
        while(time > 0) {
            string question = getRandom(_questions);
            string message = $"{prompt}\n\n{question}";
            pause(waitTime - 1, message);
            time -= waitTime;
        }
        endMessage();
    }
}