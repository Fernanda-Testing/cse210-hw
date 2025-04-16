
public abstract class Activity
{
    protected string _name;
    protected DateTime _date;
    protected double _length;

    public Activity(string name, DateTime date, double length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        return $"{formattedDate} {_name} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}