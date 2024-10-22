using System.Diagnostics.Contracts;

class Circle : Shape
{
    public double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return _radius;
    }
}