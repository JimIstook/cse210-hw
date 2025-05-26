using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string quit = Console.ReadLine();
            if ((quit == "quit") || (scripture.IsCompletelyHidden()))
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
        
    }
}