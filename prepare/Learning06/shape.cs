using System.Diagnostics.Contracts;

abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    // public void SetColor(string color)
    // {
    //     _color = color;
    // }
    // public virtual double GetArea()
    // {
    //     return -1;
    // }
    public abstract double GetArea();
    public virtual string GetSize()
    {
        return "";
    }
}