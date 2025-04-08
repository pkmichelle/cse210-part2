public class Eternal : Goal
{
    private int _reps;
    public Eternal(string name, string description, int points)
        :base(name, description, points) {}
    
    public override void RecordEvent()
    {
        _reps++;
        Console.WriteLine($"\nYour progress for '{GetName()}' has been recorded! You earned {GetPoints()} points.\n\n");
    }

    public override int GetPoints()
    {
        return base.GetPoints() * _reps;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string FormattedReference()
    {
        return $"[ ] {GetName()} - {GetDescription()}";
    }
}