namespace SkillBridgeAPI.Models.Db;

public partial class InstructionalMethod
{
    public int Id { get; set; }

    public string DisplayText { get; set; } = null!;

    public bool IsOther { get; set; }

    public int SortOrder { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public string UpdateBy { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<TrainingPlanInstructionalMethod> TrainingPlanInstructionalMethods { get; set; } = new List<TrainingPlanInstructionalMethod>();
}
