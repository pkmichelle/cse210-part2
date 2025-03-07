using System.Drawing;

public class Rectangle : Shape
{
    private int _width;
    private int _length;

    public Rectangle(string color, int width, int length)
        : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        int area;
        area = _width * _length;
        return area;
    }
}