public class ChecklistGoal: Goal {
    private int _finish;
    private int _current;
    public ChecklistGoal(string name, int finish, int points = 0): base(name, points) {
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
    public override string save() {
        string text = $"{_name}|{_points}|{_finish}|{_current}";
        return text;
    }
    public override string saveGoal()
    {
        return $"checklist|{_name}|{_points}|{_complete}|{_current}|{_finish}";
    }
}