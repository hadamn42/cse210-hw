public class Assignment{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    
    public Tuple<string, string> GetSummary(){
        return new Tuple<string, string>(_studentName, _topic);
    }
}