public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points)
        :base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"\nGoal '{GetName()}' completed! You earned {GetPoints()} points.\n\n");
    }

    public override int GetPoints()
    {
        if (_isComplete == true)
        {
            return base.GetPoints();
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string FormattedReference()
    {
        string complete = " ";
        if (_isComplete == true)
        {
            complete = "X";
        }
        else
        {
            complete = " ";
        }
        return $"[{complete}] {GetName()} - {GetDescription()}";
    }
}