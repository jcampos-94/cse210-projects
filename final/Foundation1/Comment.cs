public class Comment
{
    public string _user;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"User: {_user}");
        Console.WriteLine($"{_text}");
        Console.WriteLine();
    }
}