public class ChecklistGoal : Goal{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, string type, int target, int bonus, int amountCompleted) : base(name, description, points, type)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        
    }

    public override int RecordEvent(){
        int totalPoints;
        ++_amountCompleted;
        if (_amountCompleted == _target){
            totalPoints = _points + _bonus;
        }
        else{
            totalPoints = _points;
        }
        
        return totalPoints;
    }

    public override bool IsComplete(){
        bool isComplete;
        if (_amountCompleted == _target){
            isComplete = true;
        }
        else{
            isComplete = false;
        }
        return isComplete;
    }

    public override string GetDetailsString(){
        bool cample = IsComplete();
        string addedCample;
        if (cample == true){
            addedCample = "[X]";
        }
        else{
            addedCample = "[ ]";
        }
        return $"{addedCample} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation(){
        string line = $"{_type} | {_shortName} | {_description} | {_points} | {_target} | {_bonus} | {_amountCompleted}";
        return line;
    }
}