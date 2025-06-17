using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n\nThis will help you {_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
        Console.Clear();
        Console.WriteLine("Get ready...");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> anim = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = anim[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i == anim.Count())
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}