namespace SkillBridgeAPI.Models.Db;

public partial class TaskModel
{
    public Guid Id { get; set; }

    public Guid Actionid { get; set; }

    public long TaskNumber { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public int? State { get; set; }

    public int? Type { get; set; }

    public Guid? Agentid { get; set; }

    public Guid? OwningInstanceId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? PickupTime { get; set; }

    public DateTime? CompletedTime { get; set; }

    public byte[]? Request { get; set; }

    public byte[]? Response { get; set; }

    public int? Priority { get; set; }

    public int RetryCount { get; set; }

    public int DependencyCount { get; set; }

    public long Version { get; set; }

    public DateTime? LastResetTime { get; set; }

    public virtual ActionModel ActionModel { get; set; } = null!;

    public virtual ICollection<TaskModel> NextTasks { get; set; } = new List<TaskModel>();

    public virtual ICollection<TaskModel> PrevTasks { get; set; } = new List<TaskModel>();
}
