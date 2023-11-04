using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What grade percentage did you get? ");
        string insertGrade = Console.ReadLine();
        int grade = int.Parse(insertGrade);
        string letter = "";

        if (grade >= 90 && grade <= 100)
        {
            // Console.WriteLine("Exceptional. The grade you got is an A.");
            letter = "Exceptional. You got an A.";
        }
        else if (grade >= 80 && grade < 90)
        {
            // Console.WriteLine("The grade you got is a B.");
            letter = "Almost there. You got a B.";
        }
        else if (grade >= 70 && grade < 80)
        {
            // Console.WriteLine("The grade you got is a C.");
            letter = "Just scraping the bucket. You got a C.";
        }
        else if (grade >= 60 && grade < 70)
        {
            // Console.WriteLine("You got a D. Try harder next time.");
            letter = "Aww man. You got a D.";
        }
        else if (grade < 60)
        {
            // Console.WriteLine("To bad. You got an F.");
            letter = "Better luck next time. You got an F.";
        }

        Console.WriteLine($"{letter}");

        if (grade >= 70 && grade < 100)
        {
            Console.WriteLine("Congratulations. You passed.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Too bad. Keep studying and you will get it next time.");
        }
    }
}