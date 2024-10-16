namespace SkillBridgeAPI.Models;

public interface IProgramOrganizationListItem
{
    string Program { get; set; }
    string Url { get; set; }
    string OpportunityType { get; set; }
    string DeliveryMethod { get; set; }
    string ProgramDuration { get; set; }
    IEnumerable<string> States { get; set; }
    bool NationWide { get; set; }
    bool Online { get; set; }
    bool Cohorts { get; set; }
    string JobFamily { get; set; }
    bool LocationDetailsAvailable { get; set; }
    DateTime MouExtDate { get; set; }
}

public class ProgramOrganizationListItemModel : IProgramOrganizationListItem
{
    public string Program { get; set; }
    public string Url { get; set; }
    public string OpportunityType { get; set; }
    public string DeliveryMethod { get; set; }
    public string ProgramDuration { get; set; }
    public IEnumerable<string> States { get; set; }
    public bool NationWide { get; set; }
    public bool Online { get; set; }
    public bool Cohorts { get; set; }
    public string JobFamily { get; set; }
    public bool LocationDetailsAvailable { get; set; }
    public DateTime MouExtDate { get; set; }
}