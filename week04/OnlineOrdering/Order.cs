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
        double total = 0;
        
        foreach (Product product in _products)
        {
            
            total += product.CalculateTotalCostOfProduct() + CalculateShippingCost();
        }
       return total;
    }

    public string GetPackingLabel()
    {
        string result = "";
        foreach (Product product in _products)
        {
            result += $"-{product.GetProductName()}-> {product.GetProductId()}";
        }
        return result;
    }
    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetCustomerName()} - Address: {_customer.ShowCustomerAddress()}";
    }

    public double CalculateShippingCost()
    {
        double shippingCost;
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