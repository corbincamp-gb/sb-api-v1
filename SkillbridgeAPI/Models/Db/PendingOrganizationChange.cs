namespace SkillBridgeAPI.Models.Db;

public partial class PendingOrganizationChange
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public string? Name { get; set; }

    public string? PocFirstName { get; set; }

    public string? PocLastName { get; set; }

    public string? PocEmail { get; set; }

    public string? PocPhone { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? OrganizationUrl { get; set; }

    public int OrganizationType { get; set; }

    public string? Notes { get; set; }

    public int LegacyProviderId { get; set; }

    public int PendingChangeStatus { get; set; }

    public bool IsActive { get; set; }

    public string? LastAdminActionUser { get; set; }

    public DateTime? LastAdminActionTime { get; set; }

    public string? LastAdminActionType { get; set; }

    public string? RejectionReason { get; set; }

    public bool RequiresOsdReview { get; set; }
}
