using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Milk", "56", 2.99, 5);
        Product product2 = new Product("Eggs", "C3", 3.00, 2);
        Product product3 = new Product("Cookies", "43", 8.95, 1);
        Customer customer1 = new Customer("Mike");
        // Customer customer1 = new Customer("Mike", new Address("10120 W Flamingo Rd", "Las Vegas", "NV", "USA"));
        Address address1 = new Address("10120 W Flamingo Rd", "Las Vegas", "NV", "USA");
        Order order1 = new Order();
        Console.WriteLine(product1.GetTotal());
        Console.WriteLine(product2.GetTotal());
        Console.WriteLine(product3.GetTotal());
        Console.WriteLine(address1.GetDisplayAll());
        Console.WriteLine();
        // Console.WriteLine(order1.GetPackingLabel());

        Product product4 = new Product("Soda", "S8", 2.99, 3);
        Product product5 = new Product("Granola Bars", "79", 4.00, 2);
        Customer customer2 = new Customer("Emily");
        // Customer customer1 = new Customer("Mike", new Address("10120 W Flamingo Rd", "Las Vegas", "NV", "USA"));
        Address address2 = new Address("Str. Brusels Fin", "Strudelverst", "Germany", "Germany");
        Order order2 = new Order();
        Console.WriteLine(product4.GetTotal());
        Console.WriteLine(product5.GetTotal());
        Console.WriteLine(address2.GetDisplayAll());
        Console.WriteLine();

        Product product6 = new Product("Cereal", "71", 3.99, 3);
        Product product7 = new Product("Frozen Dinner", "F6", 7.50, 1);
        Product product8 = new Product("String Cheese", "T3", 1.00, 36);
        Customer customer3 = new Customer("Danny");
        // Customer customer1 = new Customer("Mike", new Address("10120 W Flamingo Rd", "Las Vegas", "NV", "USA"));
        Address address3 = new Address("654 S Pointe Pl", "Chicago", "IL", "USA");
        Order order3 = new Order();
        Console.WriteLine(product6.GetTotal());
        Console.WriteLine(product7.GetTotal());
        Console.WriteLine(product8.GetTotal());
        Console.WriteLine(address3.GetDisplayAll());
    }
}