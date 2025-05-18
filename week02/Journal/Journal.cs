using System;

public class Journal
{
    private PromptGenerator _promptGenerator = new PromptGenerator();
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}