using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateCost()
    {
        double total = 0;
        double shipping = 0;


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

        double totalCost = total + shipping;
        return totalCost;
    }

    public string PackingLabel()
    {
        string label = "";
        Console.WriteLine("Packing Label:");

        foreach (Product product in _products)
        {
            label += $"    {product.GetName()}; ID- {product.GetID()}; Quantity- {product.GetQuantity()}\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        string label = "";
        Console.WriteLine("Shipping Label:");

        label = $"    {_customer.GetName()}\n" +
                $"    {_customer.GetAddress().FormattedAddress()}";

        return label;
    }
}