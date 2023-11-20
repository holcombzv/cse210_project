public class Menu {
    private List<string> _options;
    private string _selection;
    User _user;
    FileHandler filehandler = new FileHandler();
    public Menu() {
        _options = new List<string>{
            "New Goal",
            "Complete Goal",
            "Show Goal List",
            "Show Score",
            "Save",
            "Load",
            "Exit"
        };
        _selection = "";
    }
    private void SetUser(User user) {
        _user = user;
        filehandler.setUser(user);
    }
    public void login() {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        User user = new User(name, new List<Goal>{});
        SetUser(user);
        Console.Clear();
    }
    private void showOptions() {
        int i = 1;
        foreach(string option in _options) {
            Console.WriteLine($"{i}. {option}");
            i ++;
        }
    }
    public void select() {
        showOptions();
        Console.WriteLine($"");
        int selection = int.Parse(Console.ReadLine());
        _selection = _options[selection - 1];
        Console.Clear();
    }
    public void runSelection() {
        if (_selection == _options[0]) {
            // New Goal
            Goal goal = createGoal();
            _user.addGoal(goal);
        }
        else if (_selection == _options[1]) {
            // Complete Goal
            completeGoal();
        }
        else if (_selection == _options[2]) {
            // Show Goal List
            listGoals();
            Console.WriteLine("\n(Enter to continue)");
            Console.ReadLine();
            Console.Clear();
        }
        else if (_selection == _options[3]) {
            // Show Score
            showScore();
        }
        else if (_selection == _options[4]) {
            // Save
            Console.WriteLine("What is the txt file name?");
            string fileName = Console.ReadLine();
            filehandler.save(fileName);
        }
        else if (_selection == _options[5]) {
            // Load
            
        }
        else if (_selection == _options[6]) {
            // Exit
            System.Environment.Exit(0);
        }
        Console.Clear();
    }
    private SimpleGoal newSimpleGoal() {
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many points is it worth?");
        string points = Console.ReadLine();
        SimpleGoal goal = new SimpleGoal(name, int.Parse(points));
        return goal;
    }
    private EternalGoal newEternalGoal() {
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many points is it worth?");
        string points = Console.ReadLine();
        EternalGoal goal = new EternalGoal(name, int.Parse(points));
        return goal;
    }
    private ChecklistGoal newChecklistGoal() {
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many points is one completion worth?");
        string points = Console.ReadLine();
        Console.WriteLine("\nHow many points is the final completion worth?");
        string finish = Console.ReadLine();
        ChecklistGoal goal = new ChecklistGoal(name, int.Parse(points), int.Parse(finish));
        Console.Clear();
        return goal;
    }
    public Goal createGoal() {
        Console.WriteLine($"What type of goal do you want to create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
        string type = Console.ReadLine();
        Console.Clear();
        Goal goal = new SimpleGoal("blank");
        if (type == "1") {
            goal = newSimpleGoal();
        }
        else if (type == "2") {
            goal = newEternalGoal();
        }
        else if (type == "3") {
            goal = newChecklistGoal();
        }
        return goal;
    }
    private void listGoals() {
        int i = 1;
        foreach (Goal goal in _user.getGoals()) {
            Console.WriteLine($"{i}. {goal.list()}");
            i ++;
        }
    }
    public void completeGoal() {
        Console.WriteLine("What goal do you want to complete?:\n");
        listGoals();
        Console.WriteLine();
        int index = int.Parse(Console.ReadLine());
        List<Goal> goals = _user.getGoals();
        goals[index - 1].Complete(_user);
        Console.Clear();
    }
    public void showScore() {
        int score = _user.getPoints();
        Console.WriteLine($"Current score: {score}\n\n(Enter to continue)");
        Console.ReadLine();
    }
}