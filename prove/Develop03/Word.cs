using System;

public class Word
{
    private string _word = "";
    
    private string _letter = "";

    public void GetWord(string word)
    {
        _word = word;
    }

    public bool IsHidden(string word)
    {
        if ("_" == word)
        {
            return true;
        }// some sort of code to know if hidden returns true or false
        else
        {
            return false;
        }
    }

}