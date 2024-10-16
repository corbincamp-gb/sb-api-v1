namespace SkillBridgeAPI.Models.Db;

public partial class TrainingPlanBreakdown
{
    public int Id { get; set; }

    public int TrainingPlanId { get; set; }

    public int? RowId { get; set; }

    public string? TrainingModuleTitle { get; set; }

    public string? LearningObjective { get; set; }

    public decimal? TotalHours { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;

    public virtual TrainingPlan TrainingPlan { get; set; } = null!;
}
