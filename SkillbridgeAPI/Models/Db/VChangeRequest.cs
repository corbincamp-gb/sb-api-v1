namespace SkillBridgeAPI.Models.Db;

public partial class VChangeRequest
{
    public int Id { get; set; }

    public bool Osd { get; set; }

    public string Type { get; set; } = null!;

    public string? Status { get; set; }

    public string Change { get; set; } = null!;

    public string? Organization { get; set; }

    public string? Program { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? LastUpdateBy { get; set; }

    public DateTime SubmittedOn { get; set; }
}
