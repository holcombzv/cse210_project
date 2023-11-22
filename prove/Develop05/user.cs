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
    public int getPoints() {
        return _points;
    }
    public void setName(string name) {
        _name = name;
    }
    public void setPoints(int points) {
        _points = points;
    }
    public void setGoals(List<Goal> goals) {
        _goals = goals;
    }
    public void addGoal(Goal goal) {
        _goals.Add(goal);
    }
    public void removeGoal(Goal goal) {
        _goals.Remove(goal);
    }
    public void addPoints(int points) {
        _points += points;
    }
}