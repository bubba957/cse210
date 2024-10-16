using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        // if (_isHidden == true)
        // {
        //     _isHidden = true;
        // }
        // else if (_isHidden == false)
        // {
        //     _isHidden = false;
        // }
        return _isHidden;
    }
    public string GetDisplayText()
    {
        _text = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
        return _text;
    }
}