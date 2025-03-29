using System;

class Program
{

    private static List<Order> _orders = new List<Order>(); 
    static void Main(string[] args)
    {
        Product tomato = new Product("Tomato", 25, 3);
        Product onion = new Product("Onion", 12, 5);
        Product milk = new Product("Milk", 32, 2);
        Product sugar = new Product("Sugar", 15, 1);
        Product spagetti = new Product("Spaggetti", 20, 2);
        Product yerbaMate = new Product("Yerba mate", 25, 1);

        Address wallStreet = new Address("Wall Street", "New York", "New York", "USA");
        Address sunier = new Address("Suñer", "Montevideo", "Montevideo", "Uruguay");
        Address boerger = new Address("Boerger", "Melo", "Cerro Largo", "Uruguay");

        Customer customerOne = new Customer("Fernanda", wallStreet);

        //I create the order with an initially empty product list
        Order orderOne = new Order(new List<Product>(), customerOne);

        orderOne.AddProduct(spagetti);
        orderOne.AddProduct(yerbaMate);

        Customer customerTwo = new Customer ("Gabriela", sunier);
        
        //I create the order with an initially empty product list
        Order orderTwo = new Order(new List<Product>(), customerTwo);

        orderTwo.AddProduct(milk);
        orderTwo.AddProduct(onion);
        orderTwo.AddProduct(tomato);

        Customer customerThree = new Customer("Sandra", boerger);

        Order orderThree = new Order(new List<Product>(), customerThree);

        orderThree.AddProduct(yerbaMate);
        orderThree.AddProduct(milk);
        orderThree.AddProduct(sugar);

        _orders.Add(orderOne);
        _orders.Add(orderTwo);
        _orders.Add(orderThree);

        foreach (Order order in _orders)
        {
        Console.WriteLine("\n--------------------ORDER--------------------\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTotal Price of the order (in $): ");
        Console.WriteLine(order.GetTotalCostOfOrder());
        }
    }
}