using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double Stock { get; set; }
    public string Producer { get; set; }
    public string PhotoPath { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    public float AvgRating { get; set; }
    public ICollection<Favourite> Favourites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}