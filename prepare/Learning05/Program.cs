using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("orange", 2, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 10);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an are of {area}.");
        }
    }
}