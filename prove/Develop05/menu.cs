public class Menu {
    private List<string> _options;
    private string _selection;
    User _user;
    FileHandler _filehandler = new FileHandler();
    public Menu() {
        // Add/Remove options here then add methods in runSelection method
        _options = new List<string>{
            "New Goal",
            "Complete Goal",
            "Remove Goal",
            "Show Goal List",
            "Show Score",
            "Exit"
        };
        _selection = "";
    }
    private void SetUser(User user) {
        _user = user;
        _filehandler.setUser(user);
    }
    public void login() {
        // Gets name from reader then creates instances of filehandler and user based on the name. Loads the file for the user if the file already exists.
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        User user = new User(name, new List<Goal>{});
        _user = user;
        _filehandler.setUser(_user);
        _filehandler.load();
        Console.Clear();
    }
    private void showOptions() {
        // Displays options to console
        int i = 1;
        foreach(string option in _options) {
            Console.WriteLine($"{i}. {option}");
            i ++;
        }
    }
    public void select() {
        // Gets a selection from Console. Input must be an integer
        showOptions();
        Console.WriteLine();
        int selection = int.Parse(Console.ReadLine());
        _selection = _options[selection - 1];
        Console.Clear();
    }
    public void runSelection() {
        // Runs the selection from the select mwthod
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
            // Remove Goal
            removeGoal();
        }
        else if (_selection == _options[3]) {
            // Show Goal List
            listGoals();
            Console.WriteLine("\n(Enter to continue)");
            Console.ReadLine();
            Console.Clear();
        }
        else if (_selection == _options[4]) {
            // Show Score
            showScore();
        }
        else if (_selection == _options[5]) {
            // Exit
            // Saves file automatically then exits the program. File created is named based on the user's name.
            _filehandler.setFileName($"{_user.getName()}.txt");
            _filehandler.save();
            System.Environment.Exit(0);
        }
        Console.Clear();
    }
    private SimpleGoal newSimpleGoal() {
        // Collects user input in order to create a new instance of a simple goal
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many points is it worth?");
        string points = Console.ReadLine();
        SimpleGoal goal = new SimpleGoal(name, int.Parse(points));
        return goal;
    }
    private EternalGoal newEternalGoal() {
        // Collects user input in order to create a new instance of an eternal goal
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many points is it worth?");
        string points = Console.ReadLine();
        EternalGoal goal = new EternalGoal(name, int.Parse(points));
        return goal;
    }
    private ChecklistGoal newChecklistGoal() {
        // Collects user input in order to create a new instance of a checklist goal
        Console.WriteLine("What is the name of the goal?");
        string name = Console.ReadLine();
        Console.WriteLine("\nHow many times will you complete this goal?");
        string finishCount = Console.ReadLine();
        Console.WriteLine("\nHow many points is one completion worth?");
        string points = Console.ReadLine();
        Console.WriteLine("\nHow many points is the final completion worth?");
        string finishPoints = Console.ReadLine();
        ChecklistGoal goal = new ChecklistGoal(name, int.Parse(finishPoints), int.Parse(finishCount), int.Parse(points));
        Console.Clear();
        return goal;
    }
    public Goal createGoal() {
        // Uses the newGoal methods to create a new goal based on the user's selction of which goal type to create
        Console.WriteLine($"What type of goal do you want to create?\n\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
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
        // Lists the goals with the index number in front of each one, then waits for the user to press enter before continuing.
        int i = 1;
        foreach (Goal goal in _user.getGoals()) {
            Console.WriteLine($"{i}. {goal.list()}");
            i ++;
        }
    }
    public void completeGoal() {
        // Calls the complete method for the selected goal.
        Console.WriteLine("What goal do you want to complete?:\n");
        listGoals();
        Console.WriteLine();
        int index = int.Parse(Console.ReadLine());
        List<Goal> goals = _user.getGoals();
        goals[index - 1].Complete(_user);
        Console.Clear();
    }
    public void removeGoal() {
        // Calls the removeGoal for the selected goal.
        Console.WriteLine("Which goal do you want to remove?");
        listGoals();
        int index = int.Parse(Console.ReadLine());
        List<Goal> goals = _user.getGoals();
        Goal goal = goals[index - 1];
        _user.removeGoal(goal);
        Console.Clear();
    }
    public void showScore() {
        // Shows the user's score in the console then waits for the user to press enter before continuing.
        int score = _user.getPoints();
        Console.WriteLine($"Current score: {score}\n\n(Enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }
}