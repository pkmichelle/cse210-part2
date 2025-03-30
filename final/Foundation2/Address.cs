public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetStreet()
    {
        Console.WriteLine("Enter street address: ");
        _street = Console.ReadLine();
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetCity()
    {
        Console.WriteLine("Enter city: ");
        _city = Console.ReadLine();
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetState()
    {
        Console.WriteLine("Enter state: ");
        _state = Console.ReadLine();
    }

    public string GetState()
    {
        return _state;
    }

    public void SetCountry()
    {
        Console.WriteLine("Enter country(abbreviated): ");
        _country = Console.ReadLine();
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool CheckCountry()
    {
        if (_country == "United States of America" || _country == "USA" || _country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void FormattedAddress()
    {
        Console.WriteLine($"{GetStreet()}");
        Console.WriteLine($"{GetCity()}, {GetState()}");
        Console.WriteLine($"{GetCountry()}");
    }
}