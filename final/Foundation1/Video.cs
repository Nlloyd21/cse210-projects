public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comments)
    {
        _comments.Add(comments);
    }
    public int GetNumberofComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberofComments()}");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"  - {comment._commenterName}: {comment._comment}");
        }
        Console.WriteLine();
    }

}