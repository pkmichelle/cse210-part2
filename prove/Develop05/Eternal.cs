public class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        :base(name, description, points)
    {}
    
    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_name} completed! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }
}