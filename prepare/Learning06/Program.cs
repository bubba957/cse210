using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue", 4);
        shapes.Add(square1);
        DisplaShape(square1);

        Rectangle rectangle1 = new Rectangle("yellow", 5, 3);
        shapes.Add(rectangle1);
        DisplaShape(rectangle1);

        Circle circle1 = new Circle("green", 2);
        shapes.Add(circle1);
        DisplaShape(circle1);

        void DisplaShape(Shape shape)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The color of the shape is {color} and its area is {area}.");
            Console.WriteLine();
        }
    }
}