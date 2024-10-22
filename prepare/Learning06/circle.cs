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
        // double _circumference = Math.Round();
        return Math.Round(Math.PI * _radius * _radius, 2);
    }
}