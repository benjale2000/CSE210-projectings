using System;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string title, string studentname, string topic) : base(studentname, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentname = GetSummary();
        return $"The title is {_title} by {studentname}";
    }
}