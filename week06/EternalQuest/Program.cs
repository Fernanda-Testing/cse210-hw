using System;
//To exceed the core requirements, I added another class called "OvercomeBadHabit",
//wich is similar to "SimpleGoal", but with the difference that if the user doesn't overcome the bad habit, 
//the checkbox is not checked and the score decreases.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}