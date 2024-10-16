namespace SkillBridgeAPI.Models.Db;

public partial class Qpresponse
{
    public int Id { get; set; }

    public int ResponseId { get; set; }

    public int SurveyId { get; set; }

    public string SurveyName { get; set; } = null!;

    public bool Duplicate { get; set; }

    public string? ResponseStatus { get; set; }

    public int? TimeTaken { get; set; }

    public string? ExternalReference { get; set; }

    public string? ZohoTicketId { get; set; }

    public string? IpAddress { get; set; }

    public string TimeStamp { get; set; } = null!;

    public DateTime ImportDate { get; set; }
}
