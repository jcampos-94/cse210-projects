using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Product product1 = new Product("Beans", 15647, 2.50, 3);
        Product product2 = new Product("Corn", 79517, 3, 5);

        Address address1 = new Address("103 N 65th St.", "Kansas City", "Kansas", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetTotalPrice());


        Product product3 = new Product("Pullman Bread", 68426, 4.20, 15);
        Product product4 = new Product("Mountain Dew", 93520, 1.25, 8);
        Product product5 = new Product("Halloween Mask", 10548, 28, 3);

        Address address2 = new Address("Los Nogales 235", "Peor es Nada", "Chimbarongo", "Chile");
        Customer customer2 = new Customer("Juanito Alcachofa", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetTotalPrice());
    }
}