using System;
using System.ComponentModel;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string word)
    {
        _text = word;
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
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hidden = new string('_', _text.Length);
            return hidden;
        }
        else
        {
            return _text;
        }
    }
}