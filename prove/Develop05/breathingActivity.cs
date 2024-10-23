class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {

    }
    public void Run(int seconds)
    {
        int i = 0;
        // ShowSpinner(GetDuration());

        while (seconds > i)
        {
            Console.Write("Breath in...");

            ShowCountDown(4);

            Console.WriteLine();

            Console.Write("And breath out...");

            ShowCountDown(6);

            Console.WriteLine();

            i = i + 10;
        }
    }
}