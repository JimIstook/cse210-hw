using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture;
        Console.WriteLine("Welcome to the scripture memorizer!\nWould you like to enter your own scripture to memorize? 'yes'/'no'");
        string yesNo = Console.ReadLine();
        if (yesNo == "yes")
        {
            Console.Write("Please enter the book: ");
            string book = Console.ReadLine();
            Console.Write("Please enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.Write("Please enter the starting verse: ");
            int verse = int.Parse(Console.ReadLine());
            Console.Write("Please enter the end verse: ");
            int endVerse = int.Parse(Console.ReadLine());
            Console.Write("Please enter the scripture: ");
            string scriptureText = Console.ReadLine();

            scripture = new Scripture(book, chapter, verse, endVerse, scriptureText);
        }
        else
        {
            scripture = new Scripture();
        }
        
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