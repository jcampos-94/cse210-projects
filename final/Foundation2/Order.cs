public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotalPrice()
    {
        bool local = _customer.GetIsLocal();
        double total;
        double subTotal;
        if(local)
        {
            total = 5;
        }else{total = 35;}

        foreach(Product product in _products)
        {
            subTotal = product.CalculateSubTotal();
            total += subTotal;
        }

        return total;
    }
    
    public string GetPackingLabel()
    {
        string name;
        int id;
        string label = null;

        foreach(Product product in _products)
        {
            name = product.GetProductName();
            id = product.GetID();
            label = label + $"{name} - ID: {id}\n";
        }
        
        return label;
    }
    
    public string GetShippingLabel()
    {
        string name = _customer.GetCustomerName();
        string address = _customer.GetAddress();
        
        return $">>\n{name}\n{address}\n";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetTotalPrice()
    {
        double total = CalculateTotalPrice();

        return "Total: $" + string.Format("{0:0.00}", total) + "\n";
    }
}
