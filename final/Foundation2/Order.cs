public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private Product _product;
    private Address _address;

    public Order(Customer customer, Product product)
    {
        _customer = customer;
        _product = product;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public Product GetProduct()
    {
        return _product;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public int CalculateCost()
    {
        int shipping = 0;

        if (_address.CheckCountry() == true)
        {
            shipping = 5;
        }
        else if (_address.CheckCountry() == false)
        {
            shipping = 35;
        }

        int price = _product.GetPrice();
        int total = price + shipping;

        return total;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Name :{product.GetName()}");
            Console.WriteLine($"ID: {product.GetID()}");
        }
    }

    public void ShippingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Name: {product.GetName()}");
            // Console.WriteLine($"Address: {_address.FormattedAddress()}");
        }
    }
}