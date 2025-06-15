using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("James", "Multiplication", "Section 1", "Problems 1-100");
        WritingAssignment essay = new WritingAssignment("Joey", "Beans", "Can of Beans");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingAssignmentInfo());
    }
}