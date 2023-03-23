public class Customer
{
    private string _customerName;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool GetIsLocal()
    {
        bool local = _address.IsLocal();

        return local;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        string address = _address.FullAddress();
        
        return address;
    }
}
