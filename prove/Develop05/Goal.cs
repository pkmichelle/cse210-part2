using System.Dynamic;
using System.Reflection.Metadata;

public abstract class Goal
{
    protected static string _name;
    protected static string _description;
    protected static int _points;
    protected static int _repetitions;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public void GetName()
    {
        Console.WriteLine("What is the name of the goal?");
        _name = Console.ReadLine();
    }

    public void GetDescription()
    {
        Console.WriteLine("Provide a short description of your goal: ");
        _description = Console.ReadLine();
    }

    public void GetPoints()
    {
        Console.WriteLine("How many points is this goal worth?");
        string _pointString = Console.ReadLine();
        _points = int.Parse(_pointString);;
    } 

    public void GetReps()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string _repeatString = Console.ReadLine();
        _repetitions = int.Parse(_repeatString);
    }

    public string FormattedReference()
    {
        // formats as $"[] {_name} - {_description} - {_points}" if type is Basic or Eternal
        // if type is Checklist $"[] {_name} - {_description} - {_points} - {_repetitions}"
    }
}