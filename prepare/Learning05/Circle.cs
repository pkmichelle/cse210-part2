public class Circle : Shape
{
    double pi = 3.14159265359;
    double _radius;

    public Circle(string color, double radius)
        : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area;
        area = pi * (_radius * _radius);
        return area;
    }
}