namespace SkillBridgeAPI.Models.Db;

public partial class QpresponseQuestionAnswer
{
    public int Id { get; set; }

    public int SurveyId { get; set; }

    public int ResponseId { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public string? AnswerText { get; set; }

    public string? ValueScale { get; set; }

    public string? ValueOther { get; set; }

    public string? ValueDynamicExplodeText { get; set; }

    public string? ValueText { get; set; }

    public string? ValueResult { get; set; }

    public string? ValueFileLink { get; set; }

    public decimal? ValueWeight { get; set; }
}
