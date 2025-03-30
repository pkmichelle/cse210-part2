using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void SetName()
    {
        Console.WriteLine("Name: ");
        _name = Console.ReadLine();
    }

    public string GetName()
    {
        return _name;
    }

    public void GetAddress()
    {
        _address.FormattedAddress();
    }

    public void CheckCountry()
    {
        _address.CheckCountry();
    }
}