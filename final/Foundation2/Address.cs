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

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
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

    public string FormattedAddress()
    {
        return $"{_street}\n    {_city}, {_state}\n    {_country}";
    }
}