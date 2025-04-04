using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private int _numberOfItemsEntered;

    private List<string> _randomPrompts = new List<string>()
    {
     "Who are people that you appreciate? ",
     "What are personal strengths of yours? ",
     "Who are people that you have helped this week? ",
     "When have you felt the Holy Ghost this month? ",
     "Who are some of your personal heroes? "
    };  
     public ListingActivity(List<string> RandomPrompts, int numberOfItemsEntered, string name, string description, int duration) : base(name, description, duration)
     {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _durationOfTheActivity = 20;
     }  
     public void Run()
     {
     }
     public string GetRandomPrompt()
     {
        Random random = new Random();
         // Generate a random index within the range of the list
         int index = random.Next(_randomPrompts.Count);
         return _randomPrompts[index];
     }
     public List<string> GetListOfResponsesFromUser()
     { 
         return _randomPrompts;
     }
 }