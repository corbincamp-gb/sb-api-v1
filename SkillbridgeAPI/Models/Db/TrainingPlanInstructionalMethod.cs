namespace SkillBridgeAPI.Models.Db;

public partial class TrainingPlanInstructionalMethod
{
    public int Id { get; set; }

    public int TrainingPlanId { get; set; }

    public int InstructionalMethodId { get; set; }

    public string? OtherText { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public virtual InstructionalMethod InstructionalMethod { get; set; } = null!;

    public virtual TrainingPlan TrainingPlan { get; set; } = null!;
}
