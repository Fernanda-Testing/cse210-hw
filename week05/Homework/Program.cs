using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignmentOne = new Assignment("Fernanda", "Inheritance");

        Console.WriteLine(assignmentOne.GetSummary());

        MathAssignment firstMathAssigment = new MathAssignment("Gabriela", "Fractions", "7.3", "8-19");

        Console.WriteLine(firstMathAssigment.GetSummary());
        Console.WriteLine(firstMathAssigment.GetHomeworkList());

        WritingAsignment firstWriting = new WritingAsignment("The Causes of World War II", "Mary Waters", "European History");

        Console.WriteLine(firstWriting.GetSummary());
        Console.WriteLine(firstWriting.GetWritingInformation());
    }
}