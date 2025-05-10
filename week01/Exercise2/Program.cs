using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num_grade;
        string letter;
        string modifier;
        string pass_fail;
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

        if (num_grade >= 70)
        {
            pass_fail = "passed";
        }
        else
        {
            pass_fail = "failed";
        }

        int second_num = num_grade % 10;
        if (second_num >= 7)
        {
            modifier = "+";
        }
        else if (second_num < 3)
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }

        if (num_grade >= 93)
        {
            modifier = "";
        }

        if (letter == "F")
        {
            modifier = "";
        }

        Console.WriteLine($"Your grade is: {letter}{modifier}");
        Console.WriteLine($"You {pass_fail} the class.");
    }
}