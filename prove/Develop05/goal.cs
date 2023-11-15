public abstract class Goal {
    protected int _points;
    protected bool _complete;
    protected string _name;
    public Goal (string name, int points) {
        _name = name;
        _points = 0;
        _complete = false;
    }
    public virtual void Complete(User user) {
        user.addPoints(_points);
    }
    public abstract string list();
}