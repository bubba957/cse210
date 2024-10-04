using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        Reference reference = new Reference("John", 3, 5);
        Scripture scripture = new Scripture(reference, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");

        Console.WriteLine(reference.GetDisplayText());

        // Console.WriteLine("John 3:5 Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        // Console.WriteLine("Press the Enter key to hide some words or type 'quit' to quit.");
    }
}