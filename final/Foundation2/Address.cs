using System;

public class Address
{
    private string _Address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Address, string city, string state, string country)
    {
        _Address = Address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_Address}\n{_city}, {_state}\n{_country}";
    }
}