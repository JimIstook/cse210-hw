using System;
using System.ComponentModel.DataAnnotations;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "relax and reflect";
        _prompts = new List<string> { "Think of a time you overcame a challenge.", "Think of a time you felt proud.", "Think of a time you helped someone.", "Think of a time you made a mistake.", "Think of a time you felt completely at peace." };
        _questions = new List<string> { "What thoughts or emotions were strongest during that moment?", "What choices did you make, and what influenced those decisions?", "What did this experience reveal about your values or character?", "How have you changed since then, and in what ways do you still carry that moment with you?", "What would you say to your past self in that moment, knowing what you know now?" };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count());
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count());
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(10);
        }
    }
}