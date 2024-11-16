using System.ComponentModel.DataAnnotations;

namespace ShopServerSide.Model;

public class Notification
{
    [Key]
    public int NotificationId { get; set; }
    public required Client Client { get; set; }
    public required string RelatedTable { get; set; }
    public required int RelatedRecordId { get; set; }
    public required bool IsRead { get; set; }
}