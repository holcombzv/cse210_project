public class SimpleGoal: Goal {
    public SimpleGoal(string name, int points): base(name, points) { }
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
}