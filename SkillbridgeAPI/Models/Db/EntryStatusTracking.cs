namespace SkillBridgeAPI.Models.Db;

public partial class EntryStatusTracking
{
    public int Id { get; set; }

    public int EntryId { get; set; }

    public string Role { get; set; } = null!;

    public int OldEntryStatusId { get; set; }

    public int NewEntryStatusId { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime AddedDate { get; set; }

    public string AddedBy { get; set; } = null!;

    public virtual Entry Entry { get; set; } = null!;
}
