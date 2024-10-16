namespace SkillBridgeAPI.Models.Db;

public partial class ProgramDeliveryMethod
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int DeliveryMethodId { get; set; }
}
