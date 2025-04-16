public class Running : Activity
{
    private double _distance;

    public Running(string name, DateTime date, double length, double distance) : base(name, date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double result = _distance / _length * 60.0;
        return result;
    }

    public override double GetPace()
    {
        double result = _length / _distance;
        return result;
    }
}