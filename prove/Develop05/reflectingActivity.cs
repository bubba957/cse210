class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private string _prompt;
    private string _question;
    public ReflectingActivity() : base()
    {

    }
    public void Run(int seconds)
    {
        string enter = "";
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("When you have your answer type enter.");
        enter = Console.ReadLine();

        if (enter == "enter")
        {
            int i = 0;

            Console.WriteLine("Now ponder on the following questions.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            while (seconds > i)
            {
                GetRandomQuestion();
                ShowCountDown(9);

                i = i + 9;
            }
        }
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
    public string GetRandomQuestion()
    {
        Random random2 = new Random();
        int line = random2.Next(5);
        string[] questions = new string[5];
        questions[0] = "What is the best thing you did today?";
        questions[1] = "Did you overcome a fear today?";
        questions[2] = "In retrospect, what was your biggest hurdle today?";
        questions[3] = "Was there anything that made your day go by better?";
        questions[4] = "Is there anything valuable you found today?";

        Console.WriteLine(questions[line]);

        return _question;
    }
    public void DisplayPrompt()
    {

    }
    public void DisplaQuestion()
    {

    }
}