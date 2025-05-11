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
        int largest = -1000;
        int smallest = 1000;

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
                    Console.WriteLine("Please enter a number.");
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
            if ((num < smallest) || (num > 0))
            {
                smallest = num;
            }
            else if (num > largest)
            {
                largest = num;
            }
        }

        average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}