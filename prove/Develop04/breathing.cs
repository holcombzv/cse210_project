public class Breathing : Activity {
    public Breathing(string name, string description): base(name, description) {}
    private void breathe(int duration, string message) {
        Console.WriteLine($"{message}\n{duration}");
        Thread.Sleep(1000);
        Console.Clear();
        base.pause(duration - 1, message);
    }
    public void run() {
        int breathDuration = 3;
        string breatheIn = "Breathe in...";
        string breatheOut = "Breathe out...";

        int time = base.startMessage();
        base.setDuration(time);
        while(time > 0) {
            breathe(breathDuration, breatheIn);
            breathe(breathDuration, breatheOut);
            time -= 2*breathDuration;
        }
        breathe(breathDuration, breatheIn);
        breathe(breathDuration, breatheOut);
        base.endMessage();
    }
}