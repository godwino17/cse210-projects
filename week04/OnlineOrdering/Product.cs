using System;
public class Product
{
    // Doing it the encapsulation way
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;
    private double _totalCost; // attribute for adding up the total cost


    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName= productName;
        _productID= productID;
        _productPrice= productPrice;
        _productQuantity= productQuantity;
    }
    public string ProductSummary() // Display product information in the
    {
        return $"Name: {_productName} | ID Number: {_productID} | Price: ${_productPrice:F2} | Quantity Ordered: {_productQuantity} | Total Cost: ${TotalCostOfEachProduct():F2}";
    }

    public double TotalCostOfEachProduct() // Multiply product  price with quantity amount & return total
    {
        _totalCost= _productPrice * _productQuantity;
        //Console.WriteLine(_totalCost);
        return _totalCost;
    }

}