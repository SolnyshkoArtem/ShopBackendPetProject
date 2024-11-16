namespace ShopServerSide.Model;

public class OrderItem
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public Product Product { get; set; }
    public float Amount { get; set; }
    public Order Order { get; set; }
}