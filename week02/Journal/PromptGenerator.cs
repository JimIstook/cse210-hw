using System;

public class PromptGenerator
{
    private Dictionary<int, string> _prompts = new Dictionary<int, string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add(0, "What made you smile today?");
        _prompts.Add(1, "What do you think you could have done better today?");
        _prompts.Add(2, "What did someone do to make your day?");
        _prompts.Add(3, "Who did you talk to today?");
        _prompts.Add(4, "What made you laugh today?");
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
}