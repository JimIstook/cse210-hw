using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the magic number game!");
        int magic_number;
        int guess;
        int count;
        bool playing = true;

        while (playing == true)
        {
            Random randomGenerator = new Random();
            magic_number = randomGenerator.Next(1, 101);
            guess = -1;
            count = 0;

            while (guess != magic_number)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Make a guess: ");
                        guess = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please enter a whole number.");
                    }
                }

                count += 1;
            }
        }
    }
}