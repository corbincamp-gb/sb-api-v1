namespace SkillBridgeAPI.Models.Db;

public partial class MouFile
{
    public int Id { get; set; }

    public int MouId { get; set; }

    public string FileName { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public long ContentLength { get; set; }

    public byte[] Blob { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual MouModel MouModel { get; set; } = null!;
}
