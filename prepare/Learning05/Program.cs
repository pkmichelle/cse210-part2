using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapesList = new List<Shape>();

        Square s1 = new Square("blue", 5);
        Rectangle r1 = new Rectangle("green", 2, 7);
        Circle c1 = new Circle("yellow", 2.7);

        _shapesList.Add(s1);
        _shapesList.Add(r1);
        _shapesList.Add(c1);

        foreach (Shape shape in _shapesList)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Radius: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}