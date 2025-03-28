class Comment
{
    string _username;
    string _commentText;

    public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_username}: {_commentText}");
    }
}