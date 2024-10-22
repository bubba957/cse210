class CheckListGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string des, string points, int target, int bonus) : base(name, des, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public string GetStringRepresentation()
    {
        return "";
    }
}