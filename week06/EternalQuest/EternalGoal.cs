public class EternalGoal : Goal
{
    public EternalGoal(int id, string name, string description, int points) : base(id, name, description, points)
    {        
    }
    
    public override void RecordEvent()
    {
        Console.WriteLine("The EternalGoal has been recorded");
    }

    public override int GetPoints()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_id},{_shortName},{_description},{_points}";
    }
}