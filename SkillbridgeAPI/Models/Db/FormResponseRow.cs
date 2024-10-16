namespace SkillBridgeAPI.Models.Db;

public partial class FormResponseRow
{
    public int Id { get; set; }

    public int FormResponseId { get; set; }

    public int RowId { get; set; }

    public int ColumnId { get; set; }

    public string? Answer { get; set; }

    public DateTime AddedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual FormResponse FormResponse { get; set; } = null!;
}
