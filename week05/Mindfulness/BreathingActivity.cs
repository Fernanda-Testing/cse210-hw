using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _activityName = name;
        _activityDescription = description;
        _durationOfTheActivity = duration;
    }
    public void Run()
    {

    }
}