namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramAdditionsDeliveryMethod
{
    public int Id { get; set; }

    public int PendingProgramId { get; set; }

    public int DeliveryMethodId { get; set; }
}
