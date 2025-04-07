using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("163 N Center St", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("5858 S 2000 W", "Roy", "Utah", "Canada");

        Customer customer1 = new Customer("Paige Koster", address1);
        Customer customer2 = new Customer("Thomas Klingler", address2);

        Product p1 = new Product("Lavender Jack 2s size 5", 200, 400, 1);
        Product p2 = new Product("Cherry Bomb Toe Stops", 133, 15, 4);
        Product p3 = new Product("Black Brunny Slide Blocks", 426, 100, 2);

        Product p4 = new Product("Limosine Boards 8.75", 222, 70, 5);
        Product p5 = new Product("Spitfire Conicals 56 mm 99 duro", 309, 40, 4);
        Product p6 = new Product("Vans Skate Old Schools", 85, 47, 2);

        Order order1 = new Order(customer1, new List<Product>{p1, p2, p3});
        Order order2 = new Order(customer2, new List<Product>{p4, p5 ,p6});


        Console.WriteLine();
        Console.WriteLine("-----Order 1-----\n");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"\nTotal: ${order1.CalculateCost()}\n\n");

        Console.WriteLine("-----Order 2-----\n");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"\nTotal: ${order2.CalculateCost()}\n\n\n");
    }
}