using System.Xml.XPath;

public class Customer 
{
    private string _name;
    private Address _address = new Address();

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address; 
    }

    public bool IsUSAResident()
    {
        bool result = _address.isInTheUSA();
        return result;
    }
}