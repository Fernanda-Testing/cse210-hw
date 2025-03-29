using System.ComponentModel;
using System.Numerics;

public class Product
{
    //Contains the name, product id, price, and quantity of each product.
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
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

    //The total cost of this product is computed by multiplying the price per unit and the quantity. 
    // (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)

    public double CalculateTotalCost()
    {
        double total = GetProductPrice() * GetQuantity();
        return total;
    }
}