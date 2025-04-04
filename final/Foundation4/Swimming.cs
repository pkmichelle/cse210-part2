public class Swimming: Activity
{
    double _laps;

    public Swimming(DateTime date, int duration, double laps)
        :base(date, duration)
        {
            _laps = laps;
        }

    public override double GetDistance()
    {
        double distance = _laps * 50 / (1000 * 0.62);
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / GetDuration() * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetDuration() / GetDistance();
        return pace;
    }
}