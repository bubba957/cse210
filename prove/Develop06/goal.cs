abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string des, int points)
    {
        // _shortName = name;
        // _description = des;
        // _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}