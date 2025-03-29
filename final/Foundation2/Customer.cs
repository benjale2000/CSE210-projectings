using System;
using System.Runtime.Intrinsics.X86;

public class Customer
{
    private string _fname = "";
    private string _lname = "";

    Address ad1 = new Address();

    public Customer(string fname, string lname)
    {
        _fname = fname;
        _lname = lname;
    }

    public Customer()
    {}

    public void GetAddress(string street, string city, string state, string country, bool foreign)
    {
        ad1.GetAddressInfo(street, city, state, country, foreign);
    }

    public void GetCustomerInfo(string fname, string lname)
    {
        _fname = fname;
        _lname = lname;
    }

    public bool ReturningForeign()
    {
        bool isforeign = ad1.ReturnForiegn();
        return isforeign;
    }

    public void Display()
    {
        Console.WriteLine($"{_fname} {_lname}");
        ad1.Display();
    }
}