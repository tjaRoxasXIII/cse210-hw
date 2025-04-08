using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = [new Square("Red", 10), new Rectangle("Blue", 15, 10), new Circle("Green", 21)];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("--------");
        }
    }
}