using System;

public class MathAssignment : Assignment
{
    private string _textbooksection = "";

    private string _problems = "";

    public MathAssignment(string textbook, string problems, string studentname, string topic) : base(studentname, topic)
    {
        _textbooksection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string studentname = GetSummary();
        return $"{_textbooksection} {_problems} {studentname}";
    }
}