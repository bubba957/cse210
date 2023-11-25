using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int quit = 0;
        Console.WriteLine("Welcome to the journal program!");

        Random rando = new Random();
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();

        while (quit != 5)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            quit = int.Parse(Console.ReadLine());

            if (quit == 1)
            {
                anEntry.Display();
                theJournal.AddEntry(anEntry);
            }
            else if (quit == 2)
            {
                theJournal.DisplayAll();
            }
            else if (quit == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if (quit == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
        }
    }
}