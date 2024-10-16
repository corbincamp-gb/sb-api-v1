namespace SkillBridgeAPI.Models.Db;

public partial class TrainingPlan
{
    public int Id { get; set; }

    public string JobTitle { get; set; } = null!;

    public string? Description { get; set; }

    public int TrainingPlanLengthId { get; set; }

    public int? BreakdownCount { get; set; }

    public string? InstructionalModules { get; set; }

    public string? WhoDelivers { get; set; }

    public string? GradingRubric { get; set; }

    public string? CredentialsEarned { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;

    public bool IsActive { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProgramTrainingPlan> ProgramTrainingPlans { get; set; } = new List<ProgramTrainingPlan>();

    public virtual ICollection<TrainingPlanBreakdown> TrainingPlanBreakdowns { get; set; } = new List<TrainingPlanBreakdown>();

    public virtual ICollection<TrainingPlanInstructionalMethod> TrainingPlanInstructionalMethods { get; set; } = new List<TrainingPlanInstructionalMethod>();

    public virtual TrainingPlanLength TrainingPlanLength { get; set; } = null!;
}
