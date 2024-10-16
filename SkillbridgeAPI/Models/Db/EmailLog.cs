namespace SkillBridgeAPI.Models.Db;

public partial class EmailLog
{
    public int Id { get; set; }

    public string SendTo { get; set; } = null!;

    public string SendFrom { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool Success { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime SendDate { get; set; }

    public string SendBy { get; set; } = null!;
}
