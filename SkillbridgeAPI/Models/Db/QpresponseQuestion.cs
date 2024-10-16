namespace SkillBridgeAPI.Models.Db;

public partial class QpresponseQuestion
{
    public int Id { get; set; }

    public int SurveyId { get; set; }

    public int ResponseId { get; set; }

    public int QuestionId { get; set; }

    public string QuestionDescription { get; set; } = null!;

    public string? QuestionCode { get; set; }

    public string? QuestionText { get; set; }
}
