using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description, 0)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationOfTheActivity);

        while(DateTime.Now < endTime)
        {
        Console.Write("\nBreathe in...");
        Thread.Sleep(500);
        ShowCountdown(6);
        
        Console.Write("\nNow breathe out...");
        Thread.Sleep(500);
        ShowCountdown(6);
        Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}