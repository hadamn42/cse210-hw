public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;
    
    public MathAssignment(string studentNamed, string topics, string textbookSection, string problems) : base(studentNamed, topics)
    {
        _studentName = studentNamed;
        _topic = topics;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public Tuple<string, string, string, string> GetHomeworkList(){
        return new Tuple<string, string, string, string>(_studentName, _topic, _textbookSection, _problems);
    }
}