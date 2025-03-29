using System;
using System.ComponentModel;

public class Comment
{
    public string _comment = "";
    public string _username = "";
    public bool _iscommented = false;

    public void GetComment(string username, string comment)
    {
        _username = username;
        _comment = comment;
        _iscommented = true;
    }

    public void Display()
    {
        Console.WriteLine($"{_username} {_comment}");
    }
}