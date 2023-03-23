public class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private int _quantity;
    
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    
    public double CalculateSubTotal()
    {
        double subTotal = _price * _quantity;
        return subTotal;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetID()
    {
        return _id;
    }
}
