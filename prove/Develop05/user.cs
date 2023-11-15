public class User {
    private int _points;
    private string _name;
    private List<Goal> _goals;
    public User (string name, List<Goal> startGoals) {
        _name = name;
        _points = 0;
        _goals = startGoals;
    }
    public string getName() {
        return _name;
    }
    public List<Goal> getGoals() {
        return _goals;
    }
    public void addGoal(Goal goal) {
        _goals.Add(goal);
    }
    public void addPoints(int points) {
        _points += points;
    }
}