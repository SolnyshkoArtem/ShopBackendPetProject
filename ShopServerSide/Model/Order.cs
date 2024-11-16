using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    public int ClientId { get; set; }
    public  Client Client { get; set; }
    public  ICollection<OrderItem> OrderItems { get; set; }
    public  string OrderStatus { get; set; }
    public int PaymentId { get; set; }
    public  Payment Payment { get; set; }
}