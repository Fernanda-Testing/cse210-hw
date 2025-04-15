public class OvercomeBadHabit : Goal
{
    private int _negativePoints;
    private bool _isComplete = false;
    private int _pointsEarned = 0;

    public OvercomeBadHabit(int id, string name, string description, int points, int negativePoints = -5) : base(id, name, description, points)
    {
        _negativePoints = negativePoints;
    }

    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This bad habit has already been overcome. No further action needed.");
            _pointsEarned = 0;
            return;
        }

        Console.Write("Did you overcome the bad habit (yes/no)? ");
        string response = Console.ReadLine().ToLower();

        if (response == "yes")
        {
            _isComplete = true;
            _pointsEarned = _points;
        }
        else if (response == "no")
        {
            Console.WriteLine("Stay strong! Try again next time.");
            _pointsEarned = _negativePoints;
        }
        else
        {
            Console.WriteLine("Invalid input. No points awarded.");
            _pointsEarned = 0;
        }
    }

    public override int GetPoints()
    {
        if (_isComplete == true)
            return _points;
        else
            return -_negativePoints;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status;

        if (IsComplete() == true)
        {
            status = "[X]";
        }
        else status = "[ ]";

        return $"{_id}. {status} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"Bad Habit:{_id},{_shortName},{_description},{_points},{_negativePoints},{_isComplete}";
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }
}
