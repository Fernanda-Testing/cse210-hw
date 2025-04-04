using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _durationOfTheActivity;
    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _activityDescription = description;
        _durationOfTheActivity = duration;
    }

    public void DisplayStartingMessage()
    {

    }
    public void PauseAndShowSpinner(int seconds)
    {

    }

    public void DisplayEndingMessage()
    {

    }
    public void PauseAndShowCountdown(int seconds)
    {

    }
}