namespace SkillBridgeAPI.Models.Db;

public partial class VwQuestionProSummaryDatum
{
    public int ResponseId { get; set; }

    public string? ResponseStatus { get; set; }

    public string TimeStamp { get; set; } = null!;

    public string? ProviderName { get; set; }

    public string? ProviderUrl { get; set; }

    public string? OrgType { get; set; }

    public string? OrgTypeOther { get; set; }

    public string? Pocfirst { get; set; }

    public string? Poclast { get; set; }

    public string? Pocemail { get; set; }

    public string? Pocphone { get; set; }

    public string? SpprogName { get; set; }

    public string? ParticPopulation { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? ProgDuration { get; set; }

    public string? OpporType { get; set; }

    public string? JobFamily { get; set; }

    public string? JobFamilyOther { get; set; }

    public string? PublicPocfirst { get; set; }

    public string? PublicPoclast { get; set; }

    public string? PublicPocemail { get; set; }

    public string? StatesDelivery { get; set; }

    public string? StatesDeliveryOther { get; set; }
}
