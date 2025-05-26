using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference()
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endverse = 6;
    }
    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = endverse;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetEnd(int endverse)
    {
        _endverse = endverse;
    }
    public string GetDisplayText()
    {
        string reference;
        if (_endverse == _verse)
        {
            reference = ($"{_book} {_chapter}:{_verse}");
        }
        else
        {
            reference = ($"{_book} {_chapter}:{_verse}-{_endverse}");
        }
        return reference;
    }
}