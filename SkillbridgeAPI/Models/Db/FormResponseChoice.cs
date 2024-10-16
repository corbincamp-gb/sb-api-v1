namespace SkillBridgeAPI.Models.Db;

public partial class FormResponseChoice
{
    public int Id { get; set; }

    public int FormResponseId { get; set; }

    public int AnswerChoiceId { get; set; }

    public DateTime AddedDate { get; set; }

    public virtual FormResponse FormResponse { get; set; } = null!;
}
