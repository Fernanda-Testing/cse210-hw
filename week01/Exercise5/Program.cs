using System;
using System.Globalization;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        
        int number =  PromptUserNumber();

        int sqrNumber = SquareNumber(number);

        DisplayResult(name, sqrNumber);
    }

    //DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    } 

    //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int squaredNum = number*number;
        return squaredNum;
    }

    //DisplayResult - Accepts the user's name and the squared number and displays them.

    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }
}