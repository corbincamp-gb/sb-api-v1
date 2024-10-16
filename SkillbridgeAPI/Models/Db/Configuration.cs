namespace SkillBridgeAPI.Models.Db;

public partial class Configuration
{
    public int Id { get; set; }

    public string ConfigKey { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public DateTime LastModified { get; set; }
}
