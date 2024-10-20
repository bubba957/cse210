using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        // Entry _entries = new Entry();

        PromptGenerator prompt = new PromptGenerator();
        
        prompt.GetRandomPrompt();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        foreach (Entry e in _entries)
        {
            // e._date = 
        }

        // _entries.Add(_date);
        // _entries.Add(_entries);
        // Entry.Add(newEntry);

        // return prompt;

        // Console.Write($"> {newEntry}");
        // string userEntry = Console.ReadLine();

        // _entries._date = 
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to 'journal.txt'...");

        string fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~|~{e._promptText}~|~{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from 'journal.txt'...");
        
        List<Entry> _entries = new List<Entry>();
        string fileName = "journal.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string l in lines)
        {
            string[] parts = l.Split("~|~");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
        }

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
}