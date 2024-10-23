using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        string quit = "";
        // string brl = "";

        while (quit != "4")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu. ");

            quit = Console.ReadLine();

            if (quit == "1")
            {
                activity.SetActivity("breathing activity");
                activity.SetDescription("relax by walking you through some breathing exercises. Get ready to calm your mind and focus on your breathing.");
                activity.DisplayStartingMessage();

                breathing.Run(activity.GetDuration());

                activity.DisplayEndingMessage();
            }
            else if (quit == "2")
            {
                activity.SetActivity("reflecting activity");
                activity.SetDescription("reflect on your life and what you have gone through to put you where you are at today.");
                activity.DisplayStartingMessage();

                reflecting.Run(activity.GetDuration());

                activity.DisplayEndingMessage();
            }
            else if (quit == "3")
            {
                activity.SetActivity("listing activity");
                activity.SetDescription("see all the good things in your life by having you list as many things as you can in a particular area.");
                activity.DisplayStartingMessage();

                listing.Run(activity.GetDuration());

                activity.DisplayEndingMessage();
            }
        }
    }
}