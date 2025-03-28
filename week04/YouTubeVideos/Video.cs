class Video
{
    string _title;
    string _author;
    int _length;

    List<Comment> comments = new List<Comment>();

    public void addComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int commentTotal(List<Comment> comments)
    {
        int commentCount = comments.Count();
        return commentCount;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideoText()
    {
        Console.WriteLine($"Video name: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Total Comments: {comments.Count()}\n");

        foreach(Comment comment in comments)
        {
            comment.DisplayComment();
        }
        
    }

}