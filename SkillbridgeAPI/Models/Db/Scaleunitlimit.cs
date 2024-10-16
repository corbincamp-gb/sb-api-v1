namespace SkillBridgeAPI.Models.Db;

public partial class Scaleunitlimit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int MaxValue { get; set; }

    public DateTime LastModified { get; set; }
}
