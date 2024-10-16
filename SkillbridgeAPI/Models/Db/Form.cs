namespace SkillBridgeAPI.Models.Db;

public partial class Form
{
    public int Id { get; set; }

    public int EntryId { get; set; }

    public int FormTemplateId { get; set; }

    public int FormOrder { get; set; }

    public DateTime AddedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual Entry Entry { get; set; } = null!;

    public virtual ICollection<FormResponse> FormResponses { get; set; } = new List<FormResponse>();

    public virtual FormTemplate FormTemplate { get; set; } = null!;
}
