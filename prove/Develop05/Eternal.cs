using System;
using System.Diagnostics.Contracts;

public class Eternal : Goals
{
    private bool _done = false;
    
    public Eternal(int points, string name, string desc) : base(points, name, desc)
    {

    }
    public Eternal(int points, string name, string desc, bool done) : base(points, name, desc)
    {
        _done = done;
    }
    
    public override bool IsComplete()
    {
        if (_done == true)
        {
            _done = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void Display()
    {
        Console.Write(_name + " ");
        Console.Write(_desc + " ");
        Console.Write(_points);
        Console.WriteLine();
    }



    public override int GetPoints()
    {
        
        return _points;
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
                _done = true;
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

    public override string GoalSave()
    {
        return $"{_points},{_name},{_desc},{_done}";
    }
}