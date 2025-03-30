public class Checklist : Goal
{

    private int _count;
    private int _repetitions;

    public Checklist( string name, string description, int points, int repetitions)
        :base(name, description, points)
    {
        _repetitions = repetitions;
    }

    public override void RecordEvent()
    {
        _count++;
    }

    public override bool IsComplete()
    {
        return true;
    }
}