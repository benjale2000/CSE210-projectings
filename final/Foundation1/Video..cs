using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    Comment c1 = new Comment();
    Comment c2 = new Comment();
    Comment c3 = new Comment();
    List<Comment> comments = new List<Comment>{};

    public void Display()
    {
        Console.WriteLine($"{_title} {_author} {_length}");
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }

    public void GetVideoInfo(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddCommentVideo(string username, string comment)
    {
        if (c1._iscommented == false)
        {
            c1.GetComment(username, comment);
            comments.Add(c1);
        }
        else if (c2._iscommented == false)
        {
            c2.GetComment(username, comment);
            comments.Add(c2);
        }
        else if (c3._iscommented == false)
        {
            c3.GetComment(username, comment);
            comments.Add(c3);
        }
    }
}