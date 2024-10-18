using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        int quit = 0;

        while (quit != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu. ");

            string contin = Console.ReadLine();
            quit = int.Parse(contin);

            if (quit == 1)
            {
                
            }
            else if (quit == 2)
            {

            }
            else if (quit == 3)
            {

            }
        }
    }
}