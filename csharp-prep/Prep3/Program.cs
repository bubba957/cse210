using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random random = new Random();
        int magicNumber = random.Next(1, 100);

        int guess = 0;
        int count = 0;
        
        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            count = count + 1;
        }
        Console.WriteLine($"You made {count} guesses.");
    }
}