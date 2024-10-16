namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramAddition
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public bool IsActive { get; set; }

    public string? ProgramName { get; set; }

    public string? OrganizationName { get; set; }

    public int OrganizationId { get; set; }

    public string? LhnIntakeTicketId { get; set; }

    public bool HasIntake { get; set; }

    public string? IntakeFormVersion { get; set; }

    public string? QpIntakeSubmissionId { get; set; }

    public bool LocationDetailsAvailable { get; set; }

    public bool HasConsent { get; set; }

    public string? QpLocationSubmissionId { get; set; }

    public string? LhnLocationTicketId { get; set; }

    public bool HasMultipleLocations { get; set; }

    public bool ReportingForm2020 { get; set; }

    public DateTime DateAuthorized { get; set; }

    public string? MouLink { get; set; }

    public DateTime MouCreationDate { get; set; }

    public DateTime MouExpirationDate { get; set; }

    public bool Nationwide { get; set; }

    public bool Online { get; set; }

    public string? ParticipationPopulations { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? StatesOfProgramDelivery { get; set; }

    public int ProgramDuration { get; set; }

    public bool SupportCohorts { get; set; }

    public string? OpportunityType { get; set; }

    public string? JobFamily { get; set; }

    public string? ServicesSupported { get; set; }

    public string? EnrollmentDates { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? ProgramUrl { get; set; }

    public bool ProgramStatus { get; set; }

    public string? AdminPocFirstName { get; set; }

    public string? AdminPocLastName { get; set; }

    public string? AdminPocEmail { get; set; }

    public string? AdminPocPhone { get; set; }

    public string? PublicPocName { get; set; }

    public string? PublicPocEmail { get; set; }

    public string? Notes { get; set; }

    public bool ForSpouses { get; set; }

    public int LegacyProgramId { get; set; }

    public int LegacyProviderId { get; set; }

    public int PendingChangeStatus { get; set; }

    public string? LastAdminActionUser { get; set; }

    public DateTime? LastAdminActionTime { get; set; }

    public string? LastAdminActionType { get; set; }

    public string? RejectionReason { get; set; }

    public bool RequiresOsdReview { get; set; }

    public string? SerializedTrainingPlan { get; set; }
}
