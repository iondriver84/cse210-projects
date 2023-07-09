class Order
{
    private List<Product> products;
    private Customer customer;

    public List<Product>Products { get {return products;}}
    public Customer Customer {get{return customer;}}

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public int CalculateTotalPrice()
    {
        int totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price;
        }
        int shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += "Name: " + product.Name + ", Product ID: " +  product.ProductID + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "shipping Label:\n";
        shippingLabel += "Name: " + customer.Name + "\n";
        shippingLabel += "Address: " + customer.Address.GetFullAddress();
        return shippingLabel;
    }
}