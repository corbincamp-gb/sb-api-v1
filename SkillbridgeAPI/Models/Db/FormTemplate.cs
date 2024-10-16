namespace SkillBridgeAPI.Models.Db;

public partial class FormTemplate
{
    public int Id { get; set; }

    public byte TemplateTypeId { get; set; }

    public string SerializedFormTemplate { get; set; } = null!;

    public DateTime AddedDate { get; set; }

    public string AddedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime RetiredDate { get; set; }

    public virtual ICollection<Form> Forms { get; set; } = new List<Form>();
}
