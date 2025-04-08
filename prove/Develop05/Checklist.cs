public class Checklist : Goal
{
    private int _goalReps;
    private int _reps;
    private int _bonus;

    public Checklist( string name, string description, int points, int goalReps, int reps, int bonus)
        :base(name, description, points)
    {
        _goalReps = goalReps;
        _reps = reps;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _reps++;
        Console.WriteLine($"\nYour progress for '{GetName()}' has been recorded! You earned {GetPoints()} points.\n\n");
    }

    public override int GetPoints()
    {
        int totalPoints = base.GetPoints() * _reps;

        if(_reps == _goalReps)
        {
            Console.WriteLine($"Congrats! You completed your checklist goal '{GetName()}'! You earned an additional {_bonus} points");
            totalPoints = GetPoints() * _reps + _bonus;
        }

        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _reps >= _goalReps;
    }

    public override string FormattedReference()
    {
        string complete = "";
        if (_reps == _goalReps)
        {
            complete = "X";
        }
        else
        {
            complete = " ";
        }
        return $"[{complete}] {GetName()} - {GetDescription()} ({_reps}/{_goalReps})";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetReps()
    {
        return _reps;
    }
}