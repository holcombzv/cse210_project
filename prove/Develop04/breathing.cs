public class Breathing : Activity {
    public Breathing(string name, string description): base(name, description) {}
    private void breathe(int duration, string message) {
        DateTime current = DateTime.Now;
        DateTime endTime = current.AddSeconds(duration);
        Console.Clear();
        pauseAnimated(duration, message);
    }
    public override void run() {
        int breathDuration = 3;
        string breatheIn = "Breathe in...";
        string breatheOut = "Breathe out...";

        int time = startMessage();
        DateTime current = DateTime.Now;
        DateTime endTime = current.AddSeconds(time);
        while(current < endTime) {
            breathe(breathDuration, breatheIn);
            breathe(breathDuration, breatheOut);
            current = DateTime.Now;
        }
        breathe(breathDuration, breatheIn);
        breathe(breathDuration, breatheOut);
        endMessage();
    }
}