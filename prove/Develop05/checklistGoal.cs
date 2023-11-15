public class ChecklistGoal: Goal {
    private int _finish;
    private int _current;
    public ChecklistGoal(string name, int points, int finish): base(name, points) {
        _finish = finish;
        _current = 0;
    }
    public override void Complete(User user)
    {
        base.Complete(user);
        _current ++;
        if (_current >= _finish) {
            _complete = true;
        }
    }
    public override string list()
    {
        string text = "";
        if(_complete) {
            text += "[x]";
        }
        else {
            text += "[ ]";
        }
        text += $" {_name}";
        return text;
    }

}