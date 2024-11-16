using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Client
{
    [Key]
    public int ClientId { get; set; }
    public required string Name { get; set; }
    public string? Adress { get; set; }
    public DateOnly Birthday { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Card>? Cards { get; set; }
    public ICollection<Favourite>? Favourites { get; set; }
    public ICollection<Review>? Reviews { get; set; }
}