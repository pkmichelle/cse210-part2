using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _scoreTotal;

    static void Main(string[] args)
    {
        while(true)
        {        
            Console.Clear();
            Console.WriteLine("Welcome to the Eternal Quest Program - Goal Tracker");
            Console.WriteLine("Please choose from the following options:");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save and quit");

            Console.Write("Choose an option: ");
            
        }
    }
}