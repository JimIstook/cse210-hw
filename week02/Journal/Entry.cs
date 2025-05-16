using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void SetDate()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }

    public void SetPrompt(string prompt)
    {
        _promptText = prompt;
    }

    public void SetResponse(string response)
    {
        _entryText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}