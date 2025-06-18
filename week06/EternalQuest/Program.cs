using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager user = new GoalManager();
        string choice = "0";
        while (choice != "6")
        {
            user.StartMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                user.CreateGoal();
            }
            else if (choice == "2")
            {
                user.ListGoalDetails();
            }
            else if (choice == "3")
            {
                user.SaveGoals();
            }
            else if (choice == "4")
            {
                user.LoadGoals();
            }
            else if (choice == "5")
            {
                user.RecordEvent();
            }
        }
    }
}