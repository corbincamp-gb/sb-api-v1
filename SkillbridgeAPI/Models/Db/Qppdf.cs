namespace SkillBridgeAPI.Models.Db;

public partial class Qppdf
{
    public int Id { get; set; }

    public int ResponseId { get; set; }

    public string? ZohoTicketId { get; set; }

    public DateTime CreateDate { get; set; }

    public string? FileName { get; set; }

    public byte[] Pdf { get; set; } = null!;
}
