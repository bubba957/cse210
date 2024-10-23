class SimpleGoal : Goal
{
    public bool _isComplete;
    public SimpleGoal(string name, string des, string points) : base(name, des, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}