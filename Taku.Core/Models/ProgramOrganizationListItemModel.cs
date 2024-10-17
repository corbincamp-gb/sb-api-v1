using Microsoft.AspNetCore.Html;
using System.Text.Json.Serialization;

namespace Taku.Core.Models;
public class ProgramOrganizationListItemModel 
{
    [JsonPropertyName("progNm")]
    public string Program { get; set; }

    public string Url { get; set; }
    [JsonPropertyName("oppType")]
    public string OpportunityType { get; set; }
    [JsonPropertyName("devMthd")]

    public string DeliveryMethod { get; set; }
    [JsonPropertyName("duration")]

    public string ProgramDuration { get; set; }
    
    public IEnumerable<string> States { get; set; }

    [JsonPropertyName("nw")]
    public bool NationWide { get; set; }
    [JsonPropertyName("ol")]

    public bool Online { get; set; }
    [JsonPropertyName("ch")]

    public bool Cohorts { get; set; }
    [JsonPropertyName("jf")]

    public string JobFamily { get; set; }
    [JsonPropertyName("lda")]

    public bool LocationDetailsAvailable { get; set; }
    [JsonPropertyName("med")]

    public DateTime MouExtDate { get; set; }
}