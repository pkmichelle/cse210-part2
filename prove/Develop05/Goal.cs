using System.Dynamic;
using System.Reflection.Metadata;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual int GetPoints()
    {
        return _points;
    } 
    public virtual string FormattedReference()
    {
        return $"[ ] {_name} - {_description}";
    }

    public abstract void RecordEvent();
    public abstract  bool IsComplete();
}