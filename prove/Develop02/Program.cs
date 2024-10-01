using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();

        int cont = 0;

        Console.WriteLine("Welcome to the program.");
        Console.WriteLine("Please select one of the following options.");

        while (cont != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string contin = Console.ReadLine();
            cont = int.Parse(contin);

            if (cont == 1)
            {
                journal.AddEntry(entry);
                journal._entries.Add(entry);
            }
            else if (cont == 2)
            {
                journal.DisplayAll();
            }
            else if (cont == 3)
            {
                journal.SaveToFile("journal.txt");
            }
            else if (cont == 4)
            {
                journal.LoadFromFile("journal.txt");
            }
        }
    }
}