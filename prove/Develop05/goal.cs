public abstract class Goal {
    protected int _points;
    protected bool _complete;
    protected string _name;
    public Goal (
            string name, // Name of goal
            int points = 0, // points awarded for completing the goal once
            bool complete = false //Whether the goal has been fully comlpeted. Should always start as flase except for in the load method
        )
        {
            _name = name;
            _points = points;
            _complete = complete;
        }
    public virtual void Complete(User user) {
        if(!_complete) {
            user.addPoints(_points);
        }
    }
    public int getPoints() {
        return _points;
    }
    public abstract string list(); // Creates string for the menu.listGoals method
    public abstract string saveGoal(); // Creates string for filehandler.save method
}