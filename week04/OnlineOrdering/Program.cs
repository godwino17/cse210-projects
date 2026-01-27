using System;
using System.Runtime.ExceptionServices;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        // Doing it the encapsulation way
        Console.WriteLine("Welcome to your mini online ordering program");
        Console.WriteLine();

        // 1st Order instance
        Address address1= new Address("123 Main st", "Ikeja", "Lagos", "Nigeria");
        Customer customer1= new Customer("Godwin Inyang",address1);        
        Product product1= new Product("iPhone", "PHN-001", 5000, 1);
        Product product2= new Product("Samsung TV", "TVS-123", 2500, 2);
        Product product3= new Product("Nike Shoes", "NKS-456", 1500, 3);
        Order order1= new Order(customer1); 

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.DisplayReceipt(); // receipt for first order

        // 2nd Order and Last order order instance.
        Address address2= new Address("456 Elm st", "Los Angeles", "California", "USA");
        Customer customer2= new Customer("Jane Smith",address2);        
        Product product4= new Product("Dell Laptop", "LAP-101", 35000, 1);
        Product product5= new Product("Sony Headphone", "HDN-202", 2500, 2);
        Product product6= new Product("Adidas Jersey", "JER-303", 800, 4);
        Order order2= new Order(customer2); 

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.DisplayReceipt(); // receipt for second order
        
        // THE END
    }
}