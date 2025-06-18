using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void StartMenu()
    {
        Console.WriteLine();
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goals");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Event");
        Console.WriteLine("    6. Quit");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"    {num}. {goal.GetName()}");
            num++;
        }
    }
    public void ListGoalDetails()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{num}. {goal.GetDetailsString()}");
            num++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        if (type == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (type == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (type == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int index = choice - 1;
        _goals[index].RecordEvent();
        _score += _goals[index].GetPoints();
        Console.WriteLine($"You earned {_goals[index].GetPoints()} points!");
    }
    public void SaveGoals()
    {
        string filename = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        string filename = "goals.txt";
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            if (line == lines[0])
            {
                continue;
            }
            else
            {
                string[] split = line.Split(":");
                string type = split[0];
                string[] details = split[1].Split(",");
                if (type == "SimpleGoal")
                {
                    SimpleGoal goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                    if (details[3] == "True")
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]));
                    for (int i = 0; i < int.Parse(details[5]); i++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
    }
}