namespace SkillBridgeAPI.Models.Db;

public partial class ProgramTrainingPlan
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int TrainingPlanId { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? ActivationChangeDate { get; set; }

    public virtual ProgramModel ProgramModel { get; set; } = null!;

    public virtual TrainingPlan TrainingPlan { get; set; } = null!;
}
