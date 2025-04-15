public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _id;
    
    public Goal(int id, string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _id = id;
    }

    public int GetId()
    {
        return _id;
    }

    public abstract int GetPoints();

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status;

        if (IsComplete() == true)
        {
            status = "[X]";
        }
        else status = "[ ]";

        return $"{GetId()}. {status} {_shortName} ({_description})";
    }

    public virtual string GetShortName()
    {
        return $"{_shortName}";
    }
    public abstract string GetStringRepresentation ();
}