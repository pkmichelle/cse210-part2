public class Square : Shape
{
    private int _side;

    public Square(string color, int side)
        : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        int area;
        area = _side * _side;
        return area;
    }
}