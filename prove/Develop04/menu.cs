public class Menu {
    private List<Activity> _activities;
    private int _selection;
    public Menu() {
        _activities = new List<Activity>();
    }
    public void setActivity (Activity newActivity) {
        _activities.Add(newActivity);
    }
    public void getSelection() {
        foreach(Activity item in _activities) {
            Console.WriteLine($"{_activities.IndexOf(item) + 1}. {item.getName()}");
        }
        int input = int.Parse(Console.ReadLine());
        _selection = input - 1;
        Console.Clear();
    }
    public void runSelection() {
        _activities[_selection].run();
    }
}

public class Exit: Activity {
    public Exit(string name, string description): base(name, description) {
        
    }
    public override void run() {
        Console.Clear();
        System.Environment.Exit(0);
    }
}