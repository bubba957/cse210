using System;

class Program
{
    static void Main(string[] args)
    {
        List<GoalManager> gm = new List<GoalManager>();

        GoalManager gmanager = new GoalManager();
        SimpleGoal sg = new SimpleGoal("", "", "");

        int points = 0;
        string quit = "";

        Console.WriteLine($"You have {points} points.");

        while (quit != "6")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            quit = Console.ReadLine();

            if (quit == "1")
            {
                gmanager.ListGoalNames();
                gmanager._goals.Add(goal);
            }
            else if (quit == "2")
            {

            }
            else if (quit == "3")
            {

            }
            else if (quit == "4")
            {

            }
            else if (quit == "5")
            {

            }
        }   

        void DisplayGoals(Goal goals)
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}