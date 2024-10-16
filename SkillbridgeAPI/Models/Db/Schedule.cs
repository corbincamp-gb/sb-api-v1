namespace SkillBridgeAPI.Models.Db;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int FreqType { get; set; }

    public int FreqInterval { get; set; }

    public virtual ICollection<ScheduleTask1> ScheduleTask1s { get; set; } = new List<ScheduleTask1>();
}
