using System;
public class Address
{
    // Doing it the encapsulation way
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string sAddress, string city, string state, string country)
    {
        _streetAddress= sAddress;
        _city= city;
        _state= state;
        _country= country;
    }

    public string CustomerAddressInfo() // Collect customers personal information.
    {
        return $"Street No: {_streetAddress}\nCity: {_city}\nState: {_state}\nCountry: {_country}";
    }

    public bool  IsInUSA() // Check if Customer is Country is USA or not.
    {
        if (_country.ToLower()== "usa" || _country.ToLower()== "united state")
        {
            return true;
        }
        return false;
    }
}