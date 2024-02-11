public class SimpleGoal : Goal{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, int points, string type) : base(name, description, points, type){
        _IsComplete = false;
    }

    public override int RecordEvent(){
        _IsComplete = true;
        return _points;
    }

    public override bool IsComplete(){
        return _IsComplete;
    }

    public override string GetStringRepresentation(){
        string line = $"{_type} | {_shortName} | {_description} | {_points} | {_IsComplete}";
        return line;
    }
}