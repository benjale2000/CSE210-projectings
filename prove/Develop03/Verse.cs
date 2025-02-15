using System;

public class Verse
{
    Word w1 = new Word();
    
    static List<string> words = new List<string> {
    "5", "Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding.",
    "6", "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."};
    Random RandomGen = new Random();

    private int _finishedcount = 0;

    private int _listcount = words.Count;

    private int _randomindex = 1;

    public void HideWord()
    {
        int innerloop = 0;
        Console.WriteLine();
        int closeloop = 0;

        while (innerloop != 3)
        {
            _randomindex = RandomGen.Next(0, _listcount);
            string word = words[_randomindex];
            bool hidden = w1.IsHidden(word);


            if (hidden != true)
            {
                words[_randomindex] = "_";
                innerloop = innerloop + 1;
                bool finished = IsFinished();
            }
            else
            {
                innerloop = 1;
                closeloop = closeloop+1;
                if (closeloop == 10)
                {
                    innerloop = 3;
                }
            }
        }
    }

    public bool IsFinished()
    {
        foreach (string word in words)
        {
            bool hidden = w1.IsHidden(word);
            if (hidden == true)
            {
                _finishedcount = _finishedcount + 1;
            }
        }

        if (_finishedcount == _listcount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayVerse()
    {
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }
}