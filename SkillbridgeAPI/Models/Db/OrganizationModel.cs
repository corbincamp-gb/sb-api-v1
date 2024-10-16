namespace SkillBridgeAPI.Models.Db;

public interface IOrganization
{
    int Id { get; set; }
    int MouId { get; set; }
    bool IsMouParent { get; set; }
    string? ParentOrganizationName { get; set; }
    string Name { get; set; }
    string PocFirstName { get; set; }
    string PocLastName { get; set; }
    string PocEmail { get; set; }
    string PocPhone { get; set; }
    DateTime DateCreated { get; set; }
    DateTime DateUpdated { get; set; }
    string? CreatedBy { get; set; }
    string? UpdatedBy { get; set; }
    string? OrganizationUrl { get; set; }
    int OrganizationType { get; set; }
    string? Notes { get; set; }
    int LegacyProviderId { get; set; }
    int LegacyMouId { get; set; }
    string? StatesOfProgramDelivery { get; set; }
    bool IsActive { get; set; }
    DateTime DateDeactivated { get; set; }
    ICollection<AspNetUserAuthority> AspNetUserAuthorities { get; set; }
    ICollection<OrganizationFile> OrganizationFiles { get; set; }
    ICollection<ProgramModel> Programs { get; set; }
}

public partial class OrganizationModel : IOrganization
{
    public int Id { get; set; }

    public int MouId { get; set; }

    public bool IsMouParent { get; set; }

    public string? ParentOrganizationName { get; set; }

    public string Name { get; set; } = null!;

    public string PocFirstName { get; set; } = null!;

    public string PocLastName { get; set; } = null!;

    public string PocEmail { get; set; } = null!;

    public string PocPhone { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? OrganizationUrl { get; set; }

    public int OrganizationType { get; set; }

    public string? Notes { get; set; }

    public int LegacyProviderId { get; set; }

    public int LegacyMouId { get; set; }

    public string? StatesOfProgramDelivery { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateDeactivated { get; set; }

    public virtual ICollection<AspNetUserAuthority> AspNetUserAuthorities { get; set; } = new List<AspNetUserAuthority>();

    public virtual ICollection<OrganizationFile> OrganizationFiles { get; set; } = new List<OrganizationFile>();

    public virtual ICollection<ProgramModel> Programs { get; set; } = new List<ProgramModel>();
}
