class Running : Activity
{
    private double _rDistance;
    private double _rSpeed;
    private double _rPace;
    public Running(double time, double distance, double speed, double pace) : base(time)
    {
        _rDistance = distance;
        _rSpeed = speed;
        _rPace = pace;
    }
    public double GetRDistance()
    {
        return _rDistance;
    }
    public double GetRSpeed()
    {
        return _rSpeed;
    }
    public double GetRPace()
    {
        return _rPace;
    }
    public string GetRunning()
    {
        DateTime fullDate = DateTime.Now;
        string date = fullDate.ToString("dd MMM yyyy");

        return $"{date} Running ({GetTime()} min) - Distance: {GetRDistance()} miles Speed: {GetRSpeed()} mph Pace: {GetRPace()} min per mile";
    }
}