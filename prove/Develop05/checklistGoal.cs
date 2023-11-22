public class ChecklistGoal: Goal {
    private int _finishPoints;
    private int _finishCount;
    private int _current;
    public ChecklistGoal(
        string name,// Name of goal
        int finishPoints,// Points awarded after the goal has been fully completed
        int finishCount,// How many times the goal should be completed before awarding all of the points
        int points,// Points awarded after the goal has been checked off one time
        bool complete = false,// Whether or not the goal is fully comlpeted. Should always be false initially except during the load method.
        int current = 0// How many times the goal has been checked off. Should never be higher than finishCount
    ): base(name, points, complete)
    {
        _finishPoints = finishPoints;
        _finishCount = finishCount;
        _current = current;
    }
    
    public override void Complete(User user)
    {
        if (!_complete) {
            // awards the user points for one check on the goal
            _current ++;
            base.Complete(user);
        }
        if (_current == _finishCount & !_complete) {
            // Awards the points for the final completion and stops the goal from progressing any further
            _complete = true;
            user.addPoints(_finishPoints);
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
        text += $" {_name} {_current}/{_finishCount}";
        return text;
    }
    public override string saveGoal()
    {
        return $"checklist|{_name}|{_finishPoints}|{_finishCount}|{_points}|{_complete}|{_current}";
    }
}