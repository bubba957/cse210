using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Customer
{
    private string _name;
    private List<Address> _addresses = new List<Address>();
    public Customer(string name, List<Address> addresses)
    {
        _name = name;
        _addresses = addresses;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public List<Address> GetCustomerAddress()
    {
        return _addresses;
    }
    // public int GetCountry()
    // {
    //     foreach (Address a in _addresses)
    //     {
    //         a.GetCountry();
    //         if (a.GetCountry() = true)
    //         {
                
    //         }
    //     }
    //     return "";
    // }
    public void SetCountry(string address)
    {

    }
}