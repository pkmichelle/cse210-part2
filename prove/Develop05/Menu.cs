public abstract class Menu
{
    static List<Goal> _goals = new List<Goal>();

    public void DisplayMenu()
    {
        while (true)
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
            string stringChoice = Console.ReadLine();
            int choice = int.Parse(stringChoice);

            while(true)
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
        Console.WriteLine("Please select the goal type: ");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        string strChoice = Console.ReadLine();
        int choice = int.Parse(strChoice);
        
        Console.WriteLine("What is the name of the goal?");
        string _name = Console.ReadLine();

        Console.WriteLine("Provide a short description of your goal: ");
        string _description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth?");
        string _pointString = Console.ReadLine();
        int _points = int.Parse(_pointString);;

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string _repeatString = Console.ReadLine();
        int _repetitions = int.Parse(_repeatString);


        while(true)
        {
            if (choice == 1)
            {
                Basic b = new Basic(_name, _description, _points); //creates basic goal instance and adds it to list
                _goals.Add(b);
                break;
            }
            else if (choice == 2)
            {
                Eternal e = new Eternal(_name, _description, _points); //creates eternal goal instance and adds it to list
                _goals.Add(e);
                break;
            }
            else if (choice == 3)
            {
                Checklist c = new Checklist(_name, _description, _points, _repetitions); //creates checklist goal instance and adds it to list
                _goals.Add(c);
                break;
            }
            else 
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Your goals: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.FormattedReference());
            // each goal in the list is printed row by row in the format in Goal.cs
        }
    }

    static void AddPoints()
    {
        //adds up all points that exist currently in the list
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}