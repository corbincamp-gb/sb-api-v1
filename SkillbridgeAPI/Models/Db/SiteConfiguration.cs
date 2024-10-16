namespace SkillBridgeAPI.Models.Db;

public partial class SiteConfiguration
{
    public int Id { get; set; }

    public int NotificationType { get; set; }

    public string? NotificationHtml { get; set; }
}
