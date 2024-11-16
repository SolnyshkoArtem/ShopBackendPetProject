using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public double Total { get; set; }
    public bool Status { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
}