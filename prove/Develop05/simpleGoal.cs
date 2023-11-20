public class SimpleGoal: Goal {
    public SimpleGoal(string name, int points = 0): base(name, points) { }
    public override void Complete(User user) {
        base.Complete(user);
        _complete = true;
    }
    public override string list() {
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
    public override string saveGoal()
    {
        return $"simple|{_name}|{_points}|{_complete}";
    }
}