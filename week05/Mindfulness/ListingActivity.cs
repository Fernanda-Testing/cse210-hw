using System;
using System.Collections.Generic;
using System.IO;

public class ListingActivity : Activity
{
    private int _numberOfItemsEntered;
    private List<string> _userResponses; // I made a list to save the responses from the user and after save them in a file

    private List<string> _randomPrompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description, 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(6);
        Console.WriteLine();

        _userResponses = GetListOfResponsesFromUser(); 
        _numberOfItemsEntered = _userResponses.Count;

        Console.WriteLine($"You listed {_numberOfItemsEntered} items!");

        Console.WriteLine("Saving the prompt with the list created in a file. \n");
        SaveToFileTheResponses(prompt, _userResponses); 

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompts.Count);
        return _randomPrompts[index];
    }

    public List<string> GetListOfResponsesFromUser()
    {
        List<string> responsesFromUser = new List<string>();
        int durationOfActivity = _durationOfTheActivity;
        int responseDuration = 10;
        int maxResponses = durationOfActivity / responseDuration;

        for (int i = 0; i < maxResponses; i++)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responsesFromUser.Add(response);
            }
        }

        return responsesFromUser;
    }

    // Method to save the prompt and the responses from the user in a file
    public void SaveToFileTheResponses(string prompt, List<string> responses)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Prompt:");
            outputFile.WriteLine(prompt);
            outputFile.WriteLine();
            outputFile.WriteLine("User Responses:");
            foreach (var response in responses)
            {
                outputFile.WriteLine($"- {response}");
            }
        }

        Console.WriteLine($"Responses saved to {filename} successfully!");
    }
}