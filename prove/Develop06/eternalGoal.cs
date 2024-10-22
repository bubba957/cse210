class EternalGoal : Goal
{
    public EternalGoal(string name, string des, string points) : base(name, des, points)
    {

    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}