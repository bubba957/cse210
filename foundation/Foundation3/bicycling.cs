class Bicycles : Activity
{
    private double _bSpeed;
    public Bicycles(double time, double speed) : base(time)
    {
        _bSpeed = speed;
    }
    public double GetBSpeed()
    {
        return _bSpeed;
    }
    public string GetBicycling()
    {
        DateTime fullDate = DateTime.Now;
        string date = fullDate.ToString("dd MMM yyyy");

        return $"{date} Bicycling ({GetTime()} min) - Speed: {GetBSpeed()} mph";
    }
}