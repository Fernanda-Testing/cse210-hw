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
        Console.WriteLine($"\nWelcome to the {_activityName} Activity\n");
        Console.WriteLine($"{_activityDescription}\n");

        Console.Write("How long in seconds, would you like for your session? ");
        string entry = Console.ReadLine();
        _durationOfTheActivity = int.Parse(entry);

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.Write("\n");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>() {"|", "/", "─", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index++;
            if (index >= animationStrings.Count)
            {
                index = 0;
            }
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_durationOfTheActivity} seconds of the {_activityName} Activity.");
        ShowSpinner(4);
    }
    
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            // Erase correctly if we have 2-digit numbers
            if (i >= 10)
            {
                Console.Write("\b \b"); 
            }
        }
    }
}