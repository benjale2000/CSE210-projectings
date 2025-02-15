using System;

public class Scripture
{
    Verse v1 = new Verse();

    public void DaProgram1()
    {
        v1.DisplayVerse();
    }

    public void DaProgram2()
    {
        v1.HideWord();
        v1.DisplayVerse();
    }

    public bool DaProgram3()
    {
        bool finished = v1.IsFinished();
        return finished;
    }
}