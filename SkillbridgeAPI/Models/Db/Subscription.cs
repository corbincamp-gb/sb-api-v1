namespace SkillBridgeAPI.Models.Db;

public partial class Subscription
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Creationtime { get; set; }

    public DateTime? Lastlogintime { get; set; }

    public int Tombstoneretentionperiodindays { get; set; }

    public int? Policyid { get; set; }

    public byte Subscriptionstate { get; set; }

    public Guid? WindowsAzureSubscriptionId { get; set; }

    public bool? EnableDetailedProviderTracing { get; set; }

    public string? Syncserveruniquename { get; set; }

    public string? Version { get; set; }

    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    public virtual ICollection<Syncgroup> Syncgroups { get; set; } = new List<Syncgroup>();

    public virtual ICollection<Userdatabase> Userdatabases { get; set; } = new List<Userdatabase>();
}
