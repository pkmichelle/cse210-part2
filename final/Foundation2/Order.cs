public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // public Customer GetCustomer()
    // {
    //     return _customer;
    // }

    // public Product GetProduct()
    // {
    //     return _product;
    // }

    // public Address GetAddress()
    // {
    //     return _address;
    // }

    public int CalculateCost()
    {
        int total = 0;
        int shipping = 0;


        foreach(Product product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.CheckCountry() == true)
        {
            shipping = 5;
        }
        else if (_customer.CheckCountry() == false)
        {
            shipping = 35;
        }

        int totalCost = total + shipping;
        return totalCost;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"    {product.GetName()}; ID- {product.GetID()}; Quantity- {product.GetQuantity()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"    {_customer.GetName()}");
        Console.WriteLine($"    {_customer.GetAddress().FormattedAddress()}");
    }
}