using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Potato", 1, 10, 2);
        Product product2 = new Product("Strawberry", 2, 20, 3);

        Address address1 = new Address("100 S 800 W", "Draper", "Utah", "USA");
        Address address2 = new Address("10 Downing St", "London", "London", "United Kingdom");

        Customer customer1 = new Customer("Squeak E. Klean", address1);
        Customer customer2 = new Customer("Sekuriti G. Yard", address2);

        List<Product> products1 = new List<Product>() {product1, product2};
        Order order1 = new Order(products1, customer1);

        List<Product> products2 = new List<Product>() {product2};
        Order order2 = new Order(products2, customer1);

        Console.WriteLine("Order 1");
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        
        Console.WriteLine("Order 2");
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        
    }

}