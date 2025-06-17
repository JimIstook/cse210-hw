using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
        }
        string choice = "";

        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        while (choice != "4")
        {
            DisplayMenu();
            choice = Console.ReadLine();
            if (choice == "1")
            {
                breathing.Run();
            }
            else if (choice == "2")
            {
                reflecting.Run();
            }
            else if (choice == "3")
            {
                listing.Run();
            }
        }
        
    }
}