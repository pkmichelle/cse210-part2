public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
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
    
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    public int CommentTotal()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("        --------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"Comments ({CommentTotal()}): ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
        Console.WriteLine("        --------");
    }
}