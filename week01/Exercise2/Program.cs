using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num_grade = 0;
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

    }
}