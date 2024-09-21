using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers;
        numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}.");

        float avg = (float)sum / numbers.Count;

        Console.WriteLine($"The average is {avg}.");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}.");

        int min = 999999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest positive number is {min}.");

    }
}