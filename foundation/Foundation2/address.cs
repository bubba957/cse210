using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _street = streetAddress;
        _city = city;
        _state = stateOrProvince;
        _country = country;
    }
    // public bool GetCountry()
    // {
    //     if (_country == "USA" || _country == "usa")
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
    public string GetDisplayAll()
    {
        return $"This customer lives on {_street} {_city}, {_state} in {_country}";
    }
}