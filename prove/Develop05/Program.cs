using System;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _scoreTotal;

    static void Main(string[] args)
    {
        DisplayMenu();
    }

    static void DisplayMenu()
        {
                Console.WriteLine("           ~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
                Console.WriteLine("Welcome to the Eternal Quest Program - Goal Tracker\n");
                Console.WriteLine("           ~~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");

            while (true)
            {
                Console.WriteLine("\n\nPlease choose from the following options:\n");

                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. Record Goal Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save and quit\n");

                Console.Write("Choose an option: ");

                string stringChoice = Console.ReadLine();
                int choice = int.Parse(stringChoice);

                {
                    if (choice == 1)
                    {
                        CreateGoal();
                    }
                    else if (choice == 2)
                    {
                        RecordEvent();
                    }
                    else if (choice == 3)
                    {
                        DisplayGoals();
                    }
                    else if (choice == 4)
                    {
                        AddPoints();
                    }
                    else 
                    {
                        Console.WriteLine("Thank you and goodbye!");
                        break;
                    }
                }
            }
        }

    static void CreateGoal()
    {
        Console.WriteLine("\nPlease select the goal type: ");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        string strChoice = Console.ReadLine();
        int choice = int.Parse(strChoice);
        
        Console.Write("\nWhat is the name of the goal? ");
        string _name = Console.ReadLine();

        Console.Write("\nProvide a short description of your goal: ");
        string _description = Console.ReadLine();

        Console.Write("\nHow many points is this goal worth? ");
        string _pointString = Console.ReadLine();
        int _points = int.Parse(_pointString);
        
    
        if (choice == 1)
        {
            Simple s = new Simple(_name, _description, _points); //creates basic goal instance and adds it to list
            _goals.Add(s);
        }
        else if (choice == 2)
        {
            Eternal e = new Eternal(_name, _description, _points); //creates eternal goal instance and adds it to list
            _goals.Add(e);
        }
        else if (choice == 3)
        {
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            string repString = Console.ReadLine();
            int repetitions = int.Parse(repString);

            Console.Write("\nHow many times have you completed this goal? ");
            string currentString = Console.ReadLine();
            int currentRepetitions = int.Parse(currentString);

            Console.Write("\nHow much is the bonus? ");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);
            
            Checklist c = new Checklist(_name, _description, _points, repetitions, currentRepetitions, bonus); //creates checklist goal instance and adds it to list
            _goals.Add(c);
        }
        else 
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nYour goals: \n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.FormattedReference());
            }
        }

        Console.WriteLine();
    }

    static void AddPoints()
    {
        foreach (Goal goal in _goals)
        {
            _scoreTotal += goal.GetPoints();
        }
        
        Console.WriteLine($"\nYour total score is: {_scoreTotal}\n");
    }
    
    public static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }

        Console.WriteLine("Select the goal you want to record an event for:");
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection, please try again.");
        }
    }
}