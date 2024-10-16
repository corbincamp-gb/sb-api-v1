namespace SkillBridgeAPI.Models.Db;

public partial class FileModel
{
    public int Id { get; set; }

    public int EntryId { get; set; }

    public string ContentType { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public long ContentLength { get; set; }

    public byte[] Blob { get; set; } = null!;

    public DateTime AddedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual Entry Entry { get; set; } = null!;

    public virtual ICollection<FormResponseFile> FormResponseFiles { get; set; } = new List<FormResponseFile>();
}
