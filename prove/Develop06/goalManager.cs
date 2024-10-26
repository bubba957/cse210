class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    SimpleGoal sg = new SimpleGoal("", "", 0);
    EternalGoal eg = new EternalGoal("", "", 0);
    CheckListGoal cg = new CheckListGoal("", "", 0, 0, 0); 
    private int _score = 0;
    private int goalNum = 0;
    public GoalManager()
    {
        
    }
    public void Start()
    {
        string quit = "";

        int points = 0;

        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();

        while (quit != "6")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            quit = Console.ReadLine();

            if (quit == "1")
            {
                CreateGoal();

                if (goalNum == 1)
                {
                    // ListGoalNames();
                }
                // gmanager._goals.Add(goal);
            }
            else if (quit == "2")
            {

            }
            else if (quit == "3")
            {

            }
            else if (quit == "4")
            {

            }
            else if (quit == "5")
            {

            }

            void DisplayGoals(Goal goals)
        {
            Console.WriteLine();
            Console.WriteLine();
        }
        }   
    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        Console.Write("What type of goal would you like to create: ");
        string goalName = Console.ReadLine();
        int goalNum = int.Parse(goalName);

        Console.Write("What is the name of your goal? ");
        string userGoal = Console.ReadLine();
        // _goals = userGoal.ToList();
        _goals.Add(sg);

        Console.Write("Give a short description of your goal: ");
        string userDescription = Console.ReadLine();
        _goals.Add(sg);

        // return goalNum;
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {
        
    }
}