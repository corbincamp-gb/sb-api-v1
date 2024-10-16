namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramAdditionsService
{
    public int Id { get; set; }

    public int PendingProgramId { get; set; }

    public int ServiceId { get; set; }
}
