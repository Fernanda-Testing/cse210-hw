using System.Diagnostics.Contracts;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int id, string name, string description, int points, int target, int bonus) : base(id, name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(int id, string name, string description, int points, int target, int bonus, int completed) : base(id, name, description, points)
    {
    _target = target;
    _bonus = bonus;
    _amountCompleted = completed;
    }

    public override int GetPoints()
    {
        return _points;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            Console.WriteLine("You have already completed your checklist for this goal.");
            return;
        }

        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        return false;
        else
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{_id},{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        string status;

        if (IsComplete() == true)
        {
            status = "[X]";
        }
        else status = "[ ]";

        return $"{_id}. {status} {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
    }
}