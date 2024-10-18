using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Cody Smith", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Lisa Sanchez", "Fractions", "7.3", "8-19");

        Console.WriteLine();
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
    
        WritingAssignment writing1 = new WritingAssignment("Margo Robbie", "European History", "The Causes of World War II");

        Console.WriteLine();
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInfo());
    }
}