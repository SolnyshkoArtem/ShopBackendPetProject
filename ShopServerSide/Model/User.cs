using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Client? Client { get; set; }
}