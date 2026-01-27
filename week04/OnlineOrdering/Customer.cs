using System;
public class Customer
{
    // Doing it the encapsulation way
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName= customerName;
        _customerAddress= customerAddress;
    }

    public string  CustomerNameAndAddress() // Collect customer name
    {
        return $"Name: {_customerName}\n{_customerAddress.CustomerAddressInfo()}";
    }
    public string LiveInUSA() // Also checks if customer is from the USA or not
    {

        if (_customerAddress.IsInUSA()== true)
        {
            return "Live in the USA";
        }
        return "Not Living In The USA";
    }
}