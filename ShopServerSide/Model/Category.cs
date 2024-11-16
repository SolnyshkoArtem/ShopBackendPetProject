using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Category
{
    [Key]
    private int CategoryId { get; set; }
    public required string Name { get; set; }
    public ICollection<Product>? Products { get; set; }
}