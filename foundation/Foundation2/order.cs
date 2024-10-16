using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Order
{
    int _totalPrice;
    string _packing;
    string _shipping;
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    // public int TotalPrice()
    // {
    //     foreach (Product p in _products)
    //     {
    //         foreach (Customer c in _customers)
    //         {
    //             double totalCost = p.GetTotal();
    //             int shipping = c.GetCountry();
    //             double _totalPrice = totalCost + shipping;
    //             Console.WriteLine(totalPrice);
    //         }
    //     }
    //     return _totalPrice;
    // }
    public string GetPackingLabel()
    {
        foreach (Product p in _products)
        {
            _packing = $"The product name is {p.GetProductName} and the ID is {p.GetProductID}";
            
        }
        return _packing;
    }
    public string GetShippingLabel()
    {
        foreach (Customer c in _customers)
        {
            _shipping = $"{c.GetCustomerName} lives on {c.GetCustomerAddress}.";
        }
        return _shipping;
    }
}