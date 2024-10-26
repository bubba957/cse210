class EternalGoal : Goal
{
    public EternalGoal(string name, string des, int points) : base(name, des, points)
    {

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