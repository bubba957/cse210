using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string answer = "yes";

        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guess = -1;
            int guessAmount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber == guess)
                {
                    Console.WriteLine("You guessed it!");
                }
                guessAmount += 1;
            }
            Console.WriteLine($"You made {guessAmount} guesses.");
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();
        }
    }
}