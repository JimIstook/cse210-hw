using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "relax and list";
        _count = 0;
        _prompts = new List<string> { "What moments stood out to you today?", "What values are most important to you right now?", "What have you learned about yourself recently? ", "Who has positively influenced your life?", "What challenges have you overcome recently?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        _count = GetListFromUser().Count();
        Console.WriteLine($"You wrote {_count} answers.");
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        int index = _random.Next(_prompts.Count());
        Console.WriteLine($" --- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);

        }
        return responses;
    }
}