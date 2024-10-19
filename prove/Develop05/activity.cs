class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = "Anonymous";
        _description = "This is an activity";
        _duration = 30;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
    }
    public void DisplayEndingMessage()
    {

    }
    public void SetActivity(string num)
    {
        // num = _name;
        _name = num;
    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {

    }
}
