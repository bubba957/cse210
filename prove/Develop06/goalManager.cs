class GoalManager
{
    public List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        Console.Write("What type of goal would you like to create: ");
        string goalName = Console.ReadLine();
    }
    public void ListGoalDetails()
    {
        Console.Write("What is the name of you goal: ");
        Console.Write("Give a short description of your goal: ");

    }
    public void CreateGoal()
    {

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