using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _scripture;
    private Random _random = new Random();

    public Scripture()
    {
        _reference = new Reference();
        _scripture = "Trust in the lord in all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        SetWords();
    }
    public Scripture(string book, int chapter, int verse, int endverse, string scripture)
    {
        _reference = new Reference(book, chapter, verse, endverse);
        _scripture = scripture;
        SetWords();
    }

    private void SetWords()
    {
        _words.Clear();
        string[] words = _scripture.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += ($" {word.GetDisplayText()}");
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}