class ListingActivity : Activity
{
    private int _count;
    private string _prompt;
    private string _entry;
    private List<string> _prompts = new List<string>();
    public ListingActivity() : base()
    {
        
    }
    public void Run(int seconds)
    {
        int i = 0;
        Console.WriteLine("List as many responses you can to the following prompt.");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        while (seconds > i)
        {
        Console.Write("> ");
        _entry = Console.ReadLine();

        i = i + 5;
        _count = _count + 1;
        }

        Console.WriteLine($"You have listed {_count} items.");
    }
    public string GetRandomPrompt()
    {
        Random random1 = new Random();
        int line = random1.Next(3);
        string[] prompts = new string[3];
        prompts[0] = "--- Think of a time you did something really dificult. ---";
        prompts[1] = "--- Remember when your faith was a little shaken. ---";
        prompts[2] = "--- In retrospect, go back to when you were a kid. ---";

        Console.WriteLine(prompts[line]);

        return _prompt;
    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}