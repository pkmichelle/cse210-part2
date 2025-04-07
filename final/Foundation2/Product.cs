public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _id;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double TotalCost()
    {
        double total = _price * _quantity;
        return total;
    }

}