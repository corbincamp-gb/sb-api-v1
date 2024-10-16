namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramAdditionsJobFamily
{
    public int Id { get; set; }

    public int PendingProgramId { get; set; }

    public int JobFamilyId { get; set; }
}
