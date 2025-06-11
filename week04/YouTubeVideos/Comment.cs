using System;
using Microsoft.VisualBasic;

public class Comment
{
    private string _author;
    private string _text;

    public Comment()
    {
        _author = "unknown";
        _text = "Empty";
    }
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string GetComment()
    {
        return $"{_author}||{_text}";
    }
}