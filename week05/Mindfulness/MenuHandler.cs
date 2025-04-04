using System;

public class MenuHandler
{
    public void ShowMenu()
    {
        Console.WriteLine("Menu options: ");
        int option = 0;
        while (option != 4)
        {
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            try
            {
                option = int.Parse(choice);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
                continue;
            }
            if (option == 1)
            {
                BreathingActivity bA = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);
                bA.Run();
            }
            else if (option == 2)
            {
                Console.WriteLine("option 2");
            }
            else if (option == 3)
            {
                Console.WriteLine("option 3");
            }
            else if (option == 4)
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("**Incorrect option** \nPlease enter a number between 1 and 4.");
            }
        }
    }
}