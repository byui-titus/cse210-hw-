using System;
using System.Collections.Generic;

public class Address
{
    private string StreetAddress { get; set; }
    private string City { get; set; }
    private string StateOrProvince { get; set; }
    private string Country { get; set; }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}, {City}, {StateOrProvince}, {Country}";
    }
}