class Swimming : Activity
{
    private int _laps;
    public Swimming(double time, int laps) : base(time)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public string GetSwimming()
    {
        DateTime fullDate = DateTime.Now;
        string date = fullDate.ToString("dd MMM yyyy");

        return $"{date} Swimming ({GetTime()} min) - Number of laps: {GetLaps()} times around the pool";
    }
}