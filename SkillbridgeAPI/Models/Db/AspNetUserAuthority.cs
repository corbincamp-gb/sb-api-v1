namespace SkillBridgeAPI.Models.Db;

public partial class AspNetUserAuthority
{
    public int Id { get; set; }

    public string ApplicationUserId { get; set; } = null!;

    public int OrganizationId { get; set; }

    public int? ProgramId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual AspNetUser ApplicationUser { get; set; } = null!;

    public virtual OrganizationModel OrganizationModel { get; set; } = null!;

    public virtual ProgramModel? Program { get; set; }
}
