using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 5);
        Scripture scripture = new Scripture(reference, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        string quit = "";

        while (quit != "quit")
        {
            Console.Clear();

            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press the Enter key to hide some words or type 'quit' to quit.");
            quit = Console.ReadLine();

            scripture.HideRandomWords(2);
        }
    }
}