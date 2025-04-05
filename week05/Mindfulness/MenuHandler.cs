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
                BreathingActivity bA = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                bA.Run();
            }
            else if (option == 2)
            {
                ReflectingActivity rA = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                rA.Run();
            }
            else if (option == 3)
            {
                ListingActivity lA = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                lA.Run();
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("**Incorrect option** \nPlease enter a number between 1 and 4.");
            }
        }
    }
}