using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _numberOfComments;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        // _comments = comment;
    }
    public int CommentList()
    {
        // foreach (Comment c in _comments)
        // {
        //     _numberOfComments =+ 1;
        // }
        _numberOfComments = _comments.Count();
        return _numberOfComments;
    }
    public string GetVideoDisplay()
    {
        string display = $"The video is called {_title} by {_author} and it is {_length} seconds long";
        return display;
    }
}