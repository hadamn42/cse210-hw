public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string studentNamed, string topics, string title) : base(studentNamed, topics){
        _studentName = studentNamed;
        _topic = topics;
        _title = title;
    }

    public Tuple<string, string, string> GetWritingInformation(){
        return new Tuple<string, string, string>(_studentName, _topic, _title);
    }
}