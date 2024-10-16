namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramDeliveryMethod
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int PendingProgramId { get; set; }

    public int DeliveryMethodId { get; set; }
}
