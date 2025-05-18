using System;

class Program
{
    static void Main(string[] args)
    {
        string command = "";
        Journal journal = new Journal();

        while (command != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            command = Console.ReadLine();
            if (command == "1")
            {
                journal.AddEntry();
            }
            else if (command == "2")
            {
                journal.DisplayAll();
            }
            else if (command == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (command == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (command != "5")
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}