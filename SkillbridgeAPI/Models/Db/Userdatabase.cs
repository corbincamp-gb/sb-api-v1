namespace SkillBridgeAPI.Models.Db;

public partial class Userdatabase
{
    public Guid Id { get; set; }

    public string? Server { get; set; }

    public string? Database { get; set; }

    public int State { get; set; }

    public Guid Subscriptionid { get; set; }

    public Guid Agentid { get; set; }

    public byte[]? ConnectionString { get; set; }

    public string? DbSchema { get; set; }

    public bool IsOnPremise { get; set; }

    public string? SqlazureInfo { get; set; }

    public DateTime? LastSchemaUpdated { get; set; }

    public DateTime? LastTombstonecleanup { get; set; }

    public string? Region { get; set; }

    public Guid? JobId { get; set; }

    public virtual Subscription Subscription { get; set; } = null!;

    public virtual ICollection<Syncgroupmember> Syncgroupmembers { get; set; } = new List<Syncgroupmember>();

    public virtual ICollection<Syncgroup> Syncgroups { get; set; } = new List<Syncgroup>();
}
