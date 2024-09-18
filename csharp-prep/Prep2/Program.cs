using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userPercent = Console.ReadLine();

        int percent = int.Parse(userPercent);
        Console.WriteLine();

        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
            percent % 10;
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"You got a/an {letter} {sign}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else if (percent < 70)
        {
            Console.WriteLine("Too bad. You'll get it next time.");
        }
    }
}