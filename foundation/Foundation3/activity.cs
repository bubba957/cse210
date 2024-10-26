class Activity
{
    private double _time;
    // private double _distance;
    // private double _speed;
    // private double _pace;
    // private string _date;
    // private string _activity;
    // Running running = new Running(3, 6, 10, "Running (30 min)", "03 Nov 2022");
    public Activity(double time)
    {
        _time = time;
        // _distance = distance;
        // _speed = speed;
        // _pace = pace;
        // _activity = activity;
    }
    // public virtual void Start()
    // {
    //     Running running = new Running(3, 6, 10);
    //     // activities.Add(running);
    //     GetSummary(running);

    //     void GetSummary(Activity activities)
    //     {
    //         double distance = GetDistance();
    //         double speed = activities.GetSpeed();
    //         double pace = activities.GetPace();

    //         Console.WriteLine($"Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min");
    //     }
    // }
    public double GetTime()
    {
        return _time;
    }
    // public double GetDistance()
    // {
    //     return _distance;
    // }
    // public double GetSpeed()
    // {
    //     return _speed;
    // }
    // public double GetPace()
    // {
    //     return _pace;
    // }
    public void GetSummary()
    {
        // DateTime fullDate = DateTime.Now;
        // string date = fullDate.ToString("dd MMM yyyy");
        // string activity = 
        // string distance = GetDistance();
        // string speed = GetSpeed();
        // string pace = GetPace();

        // Console.WriteLine($"{date}{GetDistance()}.");
        // Console.WriteLine();
    }
}