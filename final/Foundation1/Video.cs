public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    
    public int NumberOfComments()
    {
        int number = _comments.Count();
        return number;
    }
    
    public void DisplayVideoInformation()
    {
        Console.WriteLine($">Title: {_title}");
        Console.WriteLine($">Author: {_author}");
        Console.WriteLine($">Length: {_length} seconds");
        Console.WriteLine($"Comments ({NumberOfComments()} in total):");
        Console.WriteLine();

        foreach (Comment comment in _comments)
        comment.DisplayComment();
    }
}