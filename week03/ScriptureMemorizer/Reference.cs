using System;

public class Reference
{
    private string _book = "Proverbs";
    private int _chapter = 3;
    private int _verse = 5;
    private int _endverse = 6;

    public string GetDisplayText()
    {
        string reference = ($"{_book} {_chapter}:{_verse}-{_endverse}");
        return reference;
    }
}