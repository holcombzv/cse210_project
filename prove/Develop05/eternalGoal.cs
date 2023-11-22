public class EternalGoal: Goal {
    public EternalGoal(string name, int points = 0): base(name, points, false) { }
    public override void Complete(User user)
    {
        base.Complete(user);
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
    public override string saveGoal()
    {
        return $"eternal|{_name}|{_points}";
    }
}