public class Basic : Goal
{
    private bool _isComplete;

    public Basic(string name, string description, int points)
        :base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal '{_name} completed! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}