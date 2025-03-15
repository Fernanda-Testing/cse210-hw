using System;

/*To go beyond the core requirements, I've added another list to the PromptGenerator class with motivational quotes, 
called _motivationPrompts with its GetRandomPromptMotivation() method. 
A quote is printed each time the user writes in the journal.*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!\n");
        Journal journal = new Journal();

        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            try
            {
                option = int.Parse(choice);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                continue; 
            }

            if (option == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                string promptText = prompt.GetRandomPrompt();
                
                Console.Write(promptText);
                string answer = Console.ReadLine();

                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string promptMotivationText = prompt.GetRandomPromptMotivation();

                entry._date = dateText;
                entry._entryText = answer;
                entry._promptText = promptText;
                entry._promptMotivation = promptMotivationText;

                journal.AddEntry(entry);
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                journal.LoadFromFile();
            }
            else if (option == 4)
            {
                journal.SaveToFile();
            }
            else if (option == 5)
            {
                Console.WriteLine("Leaving the program... Goodbye!");
            }
            else
            {
                Console.WriteLine("**Incorrect option** \nPlease enter a number between 1 and 5.");
            }
        }
    }
}