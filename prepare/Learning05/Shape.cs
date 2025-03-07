public abstract class Shape
{
    string _color;
    int _area;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public Shape(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return _area;
    }
}