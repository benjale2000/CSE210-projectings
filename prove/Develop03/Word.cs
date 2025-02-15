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
        foreach (char letter in word)
        {
            _letter = char.ToString(letter);
        }
        if ("_" == _letter)
        {
            return true;
        }// some sort of code to know if hidden returns true or false
        else
        {
            return false;
        }
    }

}