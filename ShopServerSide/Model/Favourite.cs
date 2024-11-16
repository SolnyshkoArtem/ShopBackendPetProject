namespace ShopServerSide.Model;

public class Favourite
{
    public int ProductId { get; set; }
    public int? ClientId { get; set; }
    public Client? Client { get; set; }
    public required Product Product { get; set; }
}