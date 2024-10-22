class SimpleGoal : Goal
{
    public bool _isComplete;
    public SimpleGoal(string name, string des, string points) : base(name, des, points)
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