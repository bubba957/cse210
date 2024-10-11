using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;
    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public void SetTotal(string name, string id, double price, int quantity)
    {
        if (name == _productName && id == _id)
        {
            _price = price * quantity;
        }
    }     

    public double GetTotal()
    {
        _price = Math.Round(_price, 2);
        return _price;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public string GetProductID()
    {
        return _id;
    }
}