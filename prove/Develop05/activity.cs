class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    // private int run;
    public Activity()
    {
        // _name = "Anonymous";
        // _description = "This is an activity";
        // _duration = 30;
        // // run = 0;
    }
    public Activity(string name, string des, int dur)
    {
        _name = name;
        _description = des;
        _duration = dur;
    }
    public void DisplayStartingMessage()
    {
        // BreathingActivity breathing = new BreathingActivity();

        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like this exercise to go on for? ");
        string dur = Console.ReadLine();
        _duration = int.Parse(dur);
        // GetDuration();

        Console.WriteLine("Get ready...");
        ShowCountDown(3);

        // breathing.Run();
        // ShowSpinner(_duration);
        // DisplayEndingMessage();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Done.");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

    }
    public void SetActivity(string name)
    {
        _name = name;
    }
    public void SetDescription(string des)
    {
        _description = des;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int dur)
    {
        _duration = dur;
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();

        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        // Console.WriteLine("Get ready...");

        for (int i = seconds; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }
}
