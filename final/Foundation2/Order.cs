using System.Numerics;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void Add(Product product)
    {
        _products.Add(product);
    }
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CostofProduct();
        }
        double shipping = _customer.IsUSA() ? 5 : 35;

        return totalCost + shipping;
    }
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");

        foreach (Product product in _products)
        {
            label.AppendLine(product.GetPackingInfo());
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n {_customer.GetCustomerInfo()}";
    }


}