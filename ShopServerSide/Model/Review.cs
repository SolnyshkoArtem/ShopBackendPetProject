using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Review
{
    [Key]
    public int ReviewId { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
}