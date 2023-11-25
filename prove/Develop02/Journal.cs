using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine("Adding your entry...");
        _entries = new List<Entry>();
        _entries.Add(newEntry);
        // Console.WriteLine(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Getting your entries from the database...");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving your entry/entries...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading past entries...");

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            _entries = new List<Entry>();
            // file.AddEntry(_entries);
        }
    }
}