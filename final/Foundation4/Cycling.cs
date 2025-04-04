public class Cycling: Activity
{
    double _speed;

    public Cycling(DateTime date, int duration, double speed)
        :base(date, duration)
        {
            _speed = speed;
        }

    public override double GetDistance()
    {
        double distance = _speed * GetDuration() / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}