using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim = new Swimming(60, 20);
        Running run = new Running(30, 6);
        Cycling cycle = new Cycling(45, 25);
        List<Activity> activities = new List<Activity> { swim, run, cycle };
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}