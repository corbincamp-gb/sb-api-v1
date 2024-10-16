namespace SkillBridgeAPI.Models.Db;

public partial class Agent
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? Subscriptionid { get; set; }

    public int? State { get; set; }

    public DateTime? Lastalivetime { get; set; }

    public bool IsOnPremise { get; set; }

    public string? Version { get; set; }

    public byte[]? PasswordHash { get; set; }

    public byte[]? PasswordSalt { get; set; }

    public virtual ICollection<AgentInstance> AgentInstances { get; set; } = new List<AgentInstance>();

    public virtual Subscription? Subscription { get; set; }
}
