namespace SkillBridgeAPI.Models.Db;

public partial class ActionModel
{
    public Guid Id { get; set; }

    public Guid? SyncGroupId { get; set; }

    public int Type { get; set; }

    public int State { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }

    public virtual ICollection<TaskModel> Tasks { get; set; } = new List<TaskModel>();
}
