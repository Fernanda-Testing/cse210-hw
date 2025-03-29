public class Address
{
    private string _streetAddress;
    private string _city;
    private string _provinceOrState;
    private string _country;

    public string GetStreet()
    {
        return _streetAddress;
    }

    public void SetStreet(string street)
    {
        _streetAddress = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetProvinceOrState()
    {
        return _provinceOrState;
    }

    public void SetProvinceOrState(string provinceOrState)
    {
        _provinceOrState = provinceOrState;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool isInTheUSA()
    {
        if (GetCountry() == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        return $"{GetStreet()}, City: {GetCity()}, Province/State: {GetProvinceOrState()}, Country: {GetCountry()}";
    }
}   