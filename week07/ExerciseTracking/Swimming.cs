public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string name, DateTime date, double length, int numberOfLaps) : base(name, date, length)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        double result = _numberOfLaps * 50.0 / 1000.0;
        return result;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double minutes = _length;
        double result = distance / minutes * 60;
        return result;
    }

    public override double GetPace()
    {
        double result = _length / GetDistance();
        return result;
    }
}