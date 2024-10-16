namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramService
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int PendingProgramId { get; set; }

    public int ServiceId { get; set; }
}
