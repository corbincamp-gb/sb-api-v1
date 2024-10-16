namespace SkillBridgeAPI.Models.Db;

public interface IMou
{
    int Id { get; set; }
    DateTime CreationDate { get; set; }
    DateTime ExpirationDate { get; set; }
    DateTime ExtensionDate { get; set; }
    string? Url { get; set; }
    string? Service { get; set; }
    bool IsOsd { get; set; }
    string? OrganizationName { get; set; }
    int LegacyProviderId { get; set; }
    DateTime? NotificationDate30Days { get; set; }
    DateTime? NotificationDate60Days { get; set; }
    DateTime? NotificationDate90Days { get; set; }
    string? ZohoTicketId { get; set; }
    ICollection<MouFile> MouFiles { get; set; }
}

public partial class MouModel : IMou
{
    public int Id { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ExpirationDate { get; set; }
    public DateTime ExtensionDate { get; set; }

    public string? Url { get; set; }

    public string? Service { get; set; }

    public bool IsOsd { get; set; }

    public string? OrganizationName { get; set; }

    public int LegacyProviderId { get; set; }

    public DateTime? NotificationDate30Days { get; set; }

    public DateTime? NotificationDate60Days { get; set; }

    public DateTime? NotificationDate90Days { get; set; }

    public string? ZohoTicketId { get; set; }

    public virtual ICollection<MouFile> MouFiles { get; set; } = new List<MouFile>();
}
