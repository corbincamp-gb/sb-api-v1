namespace SkillBridgeAPI.Models.Db;

public partial class TrainingPlanLength
{
    public int Id { get; set; }

    public string DisplayText { get; set; } = null!;

    public int SortOrder { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
}
