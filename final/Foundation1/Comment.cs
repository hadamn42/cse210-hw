public class Comment {
    private string _name;
    private string _content;

    public Comment (string name, string content){
        _name = name;
        _content = content;
    }

    public string DisplayComment(){
        return $"    {_name}: {_content}";
    }
}