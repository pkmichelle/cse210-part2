using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{a1.GetSummary()}");
        // prints name and topic
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine($"{m1.GetSummary()}");
        // get summary to print the name and topic, which is derived from Assignment
        Console.WriteLine($"{m1.GetHomeworkList()}");
        // get homework list to print the section and problems, derived from MathAssignment
        // yay! it worked
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"{w1.GetSummary()}");
        Console.WriteLine($"{w1.GetWritingInformation()}");

    }
}