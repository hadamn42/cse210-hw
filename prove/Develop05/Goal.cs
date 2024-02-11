public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _type;

    public Goal(string name, string description, int points, string type){
        _shortName = name;
        _description = description;
        _points = points;
        _type = type;
    
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString(){
        bool cample = IsComplete();
        string addedCample;
        if (cample == true){
            addedCample = "[X]";
        }
        else{
            addedCample = "[ ]";
        }
        return $"{addedCample} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetToupe(){
        return _type;
    }

    public string GetName(){
        return _shortName;
    }
}