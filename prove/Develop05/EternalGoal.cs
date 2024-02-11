public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points, string type) : base(name, description, points, type){

    }

    public override int RecordEvent(){
        return _points;
    }

    public override bool IsComplete(){
        bool isComplete = false;
        return isComplete;
    }

    public override string GetStringRepresentation(){
        string line = $"{_type} | {_shortName} | {_description} | {_points}";
        return line;
    }
}