namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramJobFamily
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int PendingProgramId { get; set; }

    public int JobFamilyId { get; set; }
}
