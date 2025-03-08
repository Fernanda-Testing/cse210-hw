using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;
        int addition = 0;
        double average = 0; 
        int largest = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            string numberEntered = Console.ReadLine();
            number = int.Parse(numberEntered);
                 if (number != 0)
                     {
                        numbers.Add(number);      
                     }  
                    
            if(numbers.Count > 0)
            {
                //Compute the sum, or total, of the numbers in the list.
                addition += number; 
                //Compute the average of the numbers in the list.
                average = addition / numbers.Count;
            }
        }
            Console.WriteLine($"The sum is: {addition}");
            Console.WriteLine($"The average is: {average}");

        foreach (int num in numbers)
            {
                if (num > largest)
                    {
                    largest = num;
                    }
            }
            Console.WriteLine($"The largest is: {largest}");

        //Stretch challenge --> Sort the numbers in the list and display the new, sorted list. 
        //I used the source: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0#system-collections-generic-list-1-sort
        
        //First I show the list unsorted
        Console.WriteLine("The unsorted list is: ");
        foreach (var num in numbers)
        Console.Write("   {0}", num);
        Console.WriteLine();

        //Now sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (var num in numbers)
        Console.Write("   {0}", num);
        Console.WriteLine();
    }
}