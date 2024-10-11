using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Pipes;

public class Order
{
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    // public void TotalPrice()
    // {
    //     foreach (Product p in _products)
    //     {
    //         foreach (Customer c in _customers)
    //         {
    //             double totalCost = p.GetTotal();
    //             int shipping = c.GetCountry();
    //             double totalPrice = totalCost + shipping;
    //             Console.WriteLine(totalPrice);
    //         }
    //     }
    // }
    public void GetPackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine($"The product informations is: ");
            Console.WriteLine($"The name of the product is: {p.GetProductName}");
            Console.WriteLine($"The ID of the product is: {p.GetProductID}");
        }
        // return false;
    }
}