namespace SkillBridgeAPI.Models.Db;

public partial class FormResponseFile
{
    public int Id { get; set; }

    public int FormResponseId { get; set; }

    public int FileId { get; set; }

    public DateTime AddedDate { get; set; }

    public virtual FileModel FileModel { get; set; } = null!;

    public virtual FormResponse FormResponse { get; set; } = null!;
}
