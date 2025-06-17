using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("red", 10);
        Rectangle r = new Rectangle("blue", 5, 7);
        Circle c = new Circle("yellow", 8);
        List<Shape> shapes = new List<Shape> { s, r, c };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}