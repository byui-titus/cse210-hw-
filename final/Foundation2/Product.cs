using System;
using System.Collections.Generic;

public class Product
{
    private string Name { get; set; }
    private string ProductID { get; set; }
    private decimal Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productID, decimal price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetProductID()
    {
        return ProductID;
    }
}
