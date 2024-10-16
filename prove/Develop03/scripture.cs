using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // _words = text;
        foreach (Word w in _words)
        {
            // w = text;
            w.GetDisplayText();   
        }
        // string phrase = text;
    }
    public void HideRandomWords(int numberToHide)
    {
        foreach (Word w in _words)
        {
            // w.Hide();
            Random random = new Random();
            
        }
    }
    public string GetDisplayText()
    {
        return "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}