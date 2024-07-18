public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerName { get; set; }
    public Address ShippingAddress { get; set; }
    public List<Product> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }

    public Order()
    {
        OrderItems = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        OrderItems.Add(product);
        CalculateTotalAmount();
    }

    private void CalculateTotalAmount()
    {
        TotalAmount = OrderItems.Sum(p => p.Price);
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}