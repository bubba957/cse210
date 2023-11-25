using System.IO;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entry;

    public void Display()
    {
        Random rando = new Random();
        int line = rando.Next(5);
        string[] _promptText = new string[5];
        _promptText[0] = "What is the best thing you did today?";
        _promptText[1] = "Did you overcome a fear today?";
        _promptText[2] = "In retrospect, what was your biggest hurdle today?";
        _promptText[3] = "Was there anything that made your day go by better?";
        _promptText[4] = "Is there anything valuable you found today?";

        Console.WriteLine(_promptText[line]);
        Console.Write("> ");
        _entry = Console.ReadLine();
        // _entry = entry;

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText[line]} \n{_entry}");
    }
}