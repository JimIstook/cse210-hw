using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Ammon", "100 Lamoni rd.", "The City", "Lamoni's Land", "Land of Ishmael");
        Order order2 = new Order("James", "100 University st.", "Provo", "Utah", "USA");

        order1.AddProduct("Sword", "S123", 19.99, 5);
        order1.AddProduct("Shield", "S321", 15.50, 3);
        order1.AddProduct("Sheep", "S100", 50.25, 25);
        order1.AddProduct("Arms", "A576", 1.67, 13);

        order2.AddProduct("Eggs", "S123", 20.00, 2);
        order2.AddProduct("Milk", "S123", 7.99, 1);
        order2.AddProduct("Bagels", "S123", 10.99, 4);
        order2.AddProduct("Bacon", "S123", 8.50, 10);

        double order1Price = order1.GetTotalPrice();
        double order2Price = order2.GetTotalPrice();
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine($"${order1Price.ToString("0.##")}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine($"${order2Price.ToString("0.##")}");
    }
}