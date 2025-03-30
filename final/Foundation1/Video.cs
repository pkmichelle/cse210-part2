public class Video
{
    public string _title;
    public string _author;
    public int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }
    
    public void AddToList(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentTotal()
    {
        int commentCount;
        commentCount = _comments.Count();
        return commentCount;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"    - Comment: {comment.GetName()} — {comment.GetText()}");
        }
        Console.WriteLine("        --------");
    }
}