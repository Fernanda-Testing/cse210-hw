using System.Diagnostics.Contracts;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(int id, string name, string description, int points) : base(id, name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(int id, string name, string description, int points, bool isComplete) : base(id, name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int GetPoints()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_id},{_shortName},{_description},{_points},{_isComplete}";
    }
}