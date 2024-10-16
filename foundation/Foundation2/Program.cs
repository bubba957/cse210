using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Milk", "56", 2.99, 5);
        Customer customer1 = new Customer("Mike", address1);
        Address address1 = new Address("10120 W Flamingo Rd", "Las Vegas", "NV", "USA");
        Order order1 = new Order();
        product1.SetTotal("Milk", "56", 2.99, 5);
        Console.WriteLine(product1.GetTotal());
        Console.WriteLine(address1.GetDisplayAll());
        Console.WriteLine(order1.GetPackingLabel());
    }
}