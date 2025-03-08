using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "";
        int lastDigit = percentage % 10;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit >= 7)
        {
            Console.WriteLine($"Your letter grade is {letter}+");
        }
        else if (lastDigit < 3)
        {
            Console.WriteLine($"Your letter grade is {letter}-");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass the course");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. We encourage you not to give up and to succeed next time!");
        }
    }
}