namespace SkillBridgeAPI.Models.Db;

public partial class OpportunityGroupModel
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int OpportunityId { get; set; }

    public double Lat { get; set; }

    public double Long { get; set; }

    public string? Title { get; set; }

    public virtual OpportunityModel? OpportunityIdNavigation { get; set; }
}
