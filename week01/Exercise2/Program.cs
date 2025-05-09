using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num_grade;
        string letter;
        while (true)
        {
            try
            {
                Console.Write("What percentage grade do you have? ");
                num_grade = int.Parse(Console.ReadLine());
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            
        }

        if (num_grade >= 90)
        {
            letter = "A";
        }
        else if (num_grade >= 80)
        {
            letter = "B";
        }
        else if (num_grade >= 70)
        {
            letter = "C";
        }
        else if (num_grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
    }
}