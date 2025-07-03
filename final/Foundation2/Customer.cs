public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
    public string GetCustomerInfo()
    {
        return $"{_customerName}\n{_address.GetFullAddress()}";
    }
}