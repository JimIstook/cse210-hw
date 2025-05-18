using System;

public class PromptGenerator
{
    private Dictionary<int, string> _prompts = new Dictionary<int, string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add(0, "hello world1");
        _prompts.Add(1, "hello world2");
        _prompts.Add(2, "hello world3");
        _prompts.Add(3, "hello world4");
        _prompts.Add(4, "hello world5");
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}