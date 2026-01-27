using System;
public class Order
{
    // Doing it the encapsulation way
    private List<Product> _productList= new List<Product>();
    private Customer _customer;
    private double _totalCost; // Attribute for summing up the total cost of each product in the List.

    public Order(Customer customer)
    {
        _customer= customer;
    }

    public void AddProduct(Product product) // Method for adding product to the list.
    {
        _productList.Add(product);
    }
    
    public double TotalPrice()
    //Method Add up total price in the list including shipping fee
    {
        _totalCost= 0;
        foreach (Product items in _productList)
        {
            _totalCost+= items.TotalCostOfEachProduct();
        }

        if (_customer.LiveInUSA()== "Live in the USA")
        {
            _totalCost+= 5;
            Console.WriteLine("Shipping Fee: $5.00");
            return _totalCost;
        }
        else
        {
            _totalCost+= 35;
            Console.WriteLine("Shipping Fee: $35.00");
            return _totalCost;
        }
    }

    public void PackingLabel() // collect product summary and display it with numbers close to it
    {
         // the issue is in your PackingLabel() method inside the Order class. Right now, you’re calling
         // _productInfo.ProductSummary(), but _productInfo is never set to anything. That’s why it 
         // doesn’t display the actual products you added.

        //Instead, you should loop through _productList and call ProductSummary() on each product. 
        //Here’s the fix:
        
        for (int i=0; i < _productList.Count; i++) // Study this fix✅ The fix
        {
            //Console.WriteLine($"{i+1} - {_productInfo.ProductSummary()}");
            Console.WriteLine($"{i+1} - {_productList[i].ProductSummary()}"); // Study this fix✅ The fix
        }
    }

    public void ShippingLabel() //collect customer name and address and display them
    {
        Console.WriteLine(_customer.CustomerNameAndAddress());
    }

    public void DisplayReceipt() // study this fix ✅ The fix
    // The purpose of this method is
    // so that each Order instance can act like its own receipt. It helps prevent so that the two
    // individual order will not be added to one list.
    {
        Console.WriteLine("-----Packing Label-----");
        PackingLabel(); 
        Console.WriteLine();

        Console.WriteLine("-----Shipping Label-----");
        ShippingLabel();
        Console.WriteLine("=====================================");
        Console.WriteLine($"Total Price (including shipping): ${TotalPrice():F2}");
        Console.WriteLine("--------------------------------------"); 
        // Print the receipt in order.
    }
}