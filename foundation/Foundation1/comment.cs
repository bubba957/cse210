using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Comment
{
    private string _name;
    private string _commentText;
    private int _number;
    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }
    public string GetCommentDisplay()
    {
        string display = $"The user {_name} commented: {_commentText}";
        return display;
    }
    public int GetCommentNumber()
    {
        _number = _number + 1;
        return _number;
    }
}