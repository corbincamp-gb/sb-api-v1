namespace SkillBridgeAPI.Models.Db;

public partial class FormResponse
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public int PartId { get; set; }

    public int SectionId { get; set; }

    public int QuestionId { get; set; }

    public string? Answer { get; set; }

    public DateTime AddedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public bool IsResponseRequired { get; set; }

    public virtual Form Form { get; set; } = null!;

    public virtual ICollection<FormResponseChoice> FormResponseChoices { get; set; } = new List<FormResponseChoice>();

    public virtual ICollection<FormResponseFile> FormResponseFiles { get; set; } = new List<FormResponseFile>();

    public virtual ICollection<FormResponseRow> FormResponseRows { get; set; } = new List<FormResponseRow>();
}
