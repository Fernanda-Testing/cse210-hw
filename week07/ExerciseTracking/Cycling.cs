public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, DateTime date, double length, double speed) : base(name, date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * (_length/60.0);
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double result = _length / GetDistance();
        return result;
    }
}