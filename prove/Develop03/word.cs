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

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return false;
    }
    public string GetDisplayText()
    {
        return "";
    }
}