using System;

public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private bool _isforeign = false;

    public Address(string street, string city, string state, string country, bool foreign)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isforeign = foreign;
    }

    public Address()
    {}

    public void GetAddressInfo(string street, string city, string state, string country, bool foreign)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isforeign = foreign;
    }

    public bool ReturnForiegn()
    {
        return _isforeign;
    }

    public void Display()
    {
        Console.WriteLine($"{_street} {_city} {_state} {_country}");
    }
}