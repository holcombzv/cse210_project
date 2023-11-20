public abstract class Goal {
    protected int _points;
    protected bool _complete;
    protected string _name;
    public Goal (string name, int points = 0) {
        _name = name;
        _points = points;
        _complete = false;
    }
    public virtual void Complete(User user) {
        if(!_complete) {
            user.addPoints(_points);
        }
    }
    public int getPoints() {
        return _points;
    }
    public abstract string list();
    public virtual string save() {
        string text = $"{_name}|{_points}|{_complete}";
        return text;
    }
    public abstract string saveGoal();
}