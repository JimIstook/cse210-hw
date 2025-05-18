using System;

public class Journal
{
    private PromptGenerator _promptGenerator = new PromptGenerator();
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count() == 0)
        {
            Console.WriteLine("There are no entires to display.");
        }
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
            }
        }
        Console.WriteLine($"Saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            if (parts.Count() == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(prompt, response);
                entry._date = date;
                _entries.Add(entry);
            }

        }
        Console.WriteLine($"Loaded from {filename}");
    }
}