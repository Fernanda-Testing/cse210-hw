using System.Numerics;

public class Order 
{
    private List<Product> _products = new List<Product>(); 
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double GetTotalCostOfOrder()
    {
    //    double result = 
       return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }
    public string GetShippingLabel()
    {
        return "";
    }

    public double CalculateShippingCost(double shippingCost)
    {
        if (_customer.IsUSAResident() == true)
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }

        return shippingCost;
    }


}