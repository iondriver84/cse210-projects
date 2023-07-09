class Product
{
    private string name;
    private int productId;
    private int price;
    private int quantity;

    public string Name {get {return name; }}
    public int ProductID{get {return productId;}}
    public int Price {get {return price;}}
    public int Quantity { get { return quantity;}}

    public Product(string name, int productId, int price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
}