using System.IO;

public class PromptGenerator
{
    public List<string> _prompts;
    
    public string GetRandomPrompt()
    {
        Random rando = new Random();
        int line = rando.Next(5);
        string[] _prompt = new string[5];
        _prompt[0] = "What is the best thing you did today?";
        _prompt[1] = "Did you overcome a fear today?";
        _prompt[2] = "In retrospect, what was your biggest hurdle today?";
        _prompt[3] = "Was there anything that made your day go by better?";
        _prompt[4] = "Is there anything valuable you found today?";

        Console.WriteLine(_prompt[line]);
        Console.Write("> ");
        string entry = Console.ReadLine();

        return entry;
    }
}