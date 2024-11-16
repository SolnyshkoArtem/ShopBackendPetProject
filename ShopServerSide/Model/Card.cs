using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Card
{
    [Key]
    public int CardId { get; set; }
    public string CardNumber { get; set; }
    public string LastYear { get; set; }
    public string Keeper { get; set; }
    public Client Client { get; set; }
    public int ClientId { get; set; }
}