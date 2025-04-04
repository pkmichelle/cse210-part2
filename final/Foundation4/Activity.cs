public class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public DateTime GetDate()
    {return _date;}

    public virtual double GetDistance()
    {return 0;}

    public virtual double GetSpeed()
    {return 0;}

    public virtual double GetPace()
    {return 0;}

    private string FormatDistance()
    {
        return $"Distance {GetDistance():f1} miles";
    }

    private string FormatSpeed()
    {
        return $"Speed {GetSpeed():f1} mph";
    }

    private string FormatPace()
    {
        return $"Pace: {GetPace():f1} min per mile";
    }


    public string GetSummary()
    {
        return $"\n~~~~~~~~~~\n{_date.ToString("dd MM yyyy")} {this.GetType().Name}" +
               $"({_duration} min)- {FormatDistance()}, " +
               $"{FormatSpeed()}, {FormatPace()}\n~~~~~~~~~~";
    }
}