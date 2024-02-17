using System.IO.IsolatedStorage;

public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    private int CommentTotal(){
        return _comments.Count();
    }

    public string DisplayInfo(){
        string infos = $"Video: '{_title}' by {_author}, length (in seconds): {_length} \nComments({CommentTotal()}):";
        foreach(Comment comment in _comments){
            string cement = comment.DisplayComment();
            infos = $"{infos} \n{cement}";
        }
        return infos;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
}