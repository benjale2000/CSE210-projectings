using System;

public abstract class Goals
{
    protected int _points = 0;
    protected string _name = "";
    protected string _desc = "";

    public Goals()
    {}

    public Goals(int points, string name, string desc)
    {
        _points = points;
        _name = name;
        _desc = desc;
    }

    public abstract bool IsComplete();

    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual int PointReturn()
    {
        return 0;
    }

    public abstract void Display();

    public abstract void GoalManage();

    public abstract string GoalSave();
}