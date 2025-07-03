using System.IO.Pipes;

public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _quantity;

    public Product(string ProductName, string ProductID, double ProductPrice, int quantity)
    {
        _productName = ProductName;
        _productID = ProductID;
        _productPrice = ProductPrice;
        _quantity = quantity;
    }

    public double CostofProduct()
    {
        return _productPrice * _quantity;
    }
    public string GetPackingInfo()
    {
        return $"{_productName} ID: {_productID}";
    }
}