using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        float average;
        int largest = int.MinValue;
        int smallest = int.MaxValue;

        while (true)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }
            
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }

        }
        
        foreach (int num in numbers)
        {
            sum += num;
            if ((num < smallest) && (num > 0))
            {
                smallest = num;
            }
            
            if (num > largest)
            {
                largest = num;
            }
        }

        average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallest == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");
        }
    }
}