using System;

public class Checklist : Goals
{
    private int _bonus = 0;
    private int _totaltimes = 0;
    private int _times = 0;
    private int _prevtimes = 0;
    private bool _done = false;

    public Checklist(int points, string name, string desc, bool done, int bonus, int totaltimes, int times) : base(points, name, desc)
    {
        _bonus = bonus;
        _totaltimes = totaltimes;
        _times = times;
        _done = done;
    }

    public Checklist(int points, string name, string desc, bool done, int bonus, int totaltimes, int times, int prevtimes) : base(points, name, desc)
    {
        _bonus = bonus;
        _totaltimes = totaltimes;
        _times = times;
        _done = done;
        _prevtimes = prevtimes;
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        if (_times == _totaltimes)
        {
            _done = true;
            return _done;
        }
        else
        {
            return _done;
        }
        
    }

    public override void Display()
    {
        Console.Write(_done);
        Console.Write(_name + " ");
        Console.Write(_desc + " ");
        Console.Write(_times + " ");
        Console.Write(_totaltimes + " ");
        Console.Write(_points + " ");
        Console.Write(_bonus);
        Console.WriteLine();
    }

    public override void GoalManage()
    {
        string miniloop = "1";
        while (miniloop != "0")
        {
            Console.WriteLine("Did you finish the goal? please type in Y or N");
            string donestring = Console.ReadLine();
            if ((donestring == "Y") || (donestring == "y"))
            {
                if (_times == _totaltimes)
                {
                    _times = _times + 1;
                }
                miniloop = "0";
            }
            else if ((donestring == "N") || (donestring == "n"))
            {
                miniloop = "0";
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("unknown input, please try again");
                Console.WriteLine();
            }
        }
    }

    public override int PointReturn()
    {
        if (_times > _prevtimes)
        {
            _prevtimes = _prevtimes + 1;
            return GetPoints();
        }
        else
        {
            return 0;
        }
    }

    public override string GoalSave()
    {
        return $"{_points},{_name},{_desc},{_done},{_bonus}, {_totaltimes}, {_times}, {_prevtimes}";
    }
}