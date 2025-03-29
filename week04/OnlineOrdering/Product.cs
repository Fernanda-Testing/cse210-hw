using System.ComponentModel;
using System.Numerics;

public class Product
{
    private static int _nextId = 1;  // Static variable for incremental ID 
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity)
    {
        _productName = name;
        _productId = _nextId++;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
    public double GetProductPrice()
    {
        return _price;
    }

    public void SetProductPrice(double productPrice)
    {
        _price = productPrice;
    }

        public double GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double CalculateTotalCostOfProduct()
    {
        double total = GetProductPrice() * GetQuantity();
        return total;
    }
}