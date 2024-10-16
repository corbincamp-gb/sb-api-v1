namespace SkillBridgeAPI.Models.Db;

public interface IProgram
{
    int Id { get; set; }
    string ProgramName { get; set; }
    string? OrganizationName { get; set; }
    int OrganizationId { get; set; }
    string? LhnIntakeTicketId { get; set; }
    bool HasIntake { get; set; }
    string? IntakeFormVersion { get; set; }
    string? QpIntakeSubmissionId { get; set; }
    bool LocationDetailsAvailable { get; set; }
    bool HasConsent { get; set; }
    string? QpLocationSubmissionId { get; set; }
    string? LhnLocationTicketId { get; set; }
    bool HasMultipleLocations { get; set; }
    bool ReportingForm2020 { get; set; }
    DateTime DateAuthorized { get; set; }
    string MouLink { get; set; }
    DateTime MouCreationDate { get; set; }
    DateTime MouExpirationDate { get; set; }
    bool Nationwide { get; set; }
    bool Online { get; set; }
    string? ParticipationPopulations { get; set; }
    string? DeliveryMethod { get; set; }
    string? StatesOfProgramDelivery { get; set; }
    int ProgramDuration { get; set; }
    bool SupportCohorts { get; set; }
    string OpportunityType { get; set; }
    string? JobFamily { get; set; }
    string? ServicesSupported { get; set; }
    string? EnrollmentDates { get; set; }
    DateTime DateCreated { get; set; }
    DateTime DateUpdated { get; set; }
    string? CreatedBy { get; set; }
    string? UpdatedBy { get; set; }
    string? ProgramUrl { get; set; }
    bool ProgramStatus { get; set; }
    string AdminPocFirstName { get; set; }
    string AdminPocLastName { get; set; }
    string AdminPocEmail { get; set; }
    string AdminPocPhone { get; set; }
    string PublicPocName { get; set; }
    string PublicPocEmail { get; set; }
    string? Notes { get; set; }
    bool ForSpouses { get; set; }
    int LegacyProgramId { get; set; }
    int LegacyProviderId { get; set; }
    bool IsActive { get; set; }
    DateTime DateDeactivated { get; set; }
    string? OtherDescription { get; set; }
    ICollection<AspNetUserAuthority> AspNetUserAuthorities { get; set; }
    OrganizationModel OrganizationModel { get; set; }
    ICollection<ProgramTrainingPlan> ProgramTrainingPlans { get; set; }
}

public partial class ProgramModel : IProgram
{
    public int Id { get; set; }

    public string ProgramName { get; set; } = null!;

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

    public string MouLink { get; set; } = null!;

    public DateTime MouCreationDate { get; set; }

    public DateTime MouExpirationDate { get; set; }
    
    public bool Nationwide { get; set; }

    public bool Online { get; set; }

    public string? ParticipationPopulations { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? StatesOfProgramDelivery { get; set; }

    public int ProgramDuration { get; set; }

    public bool SupportCohorts { get; set; }

    public string OpportunityType { get; set; } = null!;

    public string? JobFamily { get; set; }

    public string? ServicesSupported { get; set; }

    public string? EnrollmentDates { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? ProgramUrl { get; set; }

    public bool ProgramStatus { get; set; }

    public string AdminPocFirstName { get; set; } = null!;

    public string AdminPocLastName { get; set; } = null!;

    public string AdminPocEmail { get; set; } = null!;

    public string AdminPocPhone { get; set; } = null!;

    public string PublicPocName { get; set; } = null!;

    public string PublicPocEmail { get; set; } = null!;

    public string? Notes { get; set; }

    public bool ForSpouses { get; set; }

    public int LegacyProgramId { get; set; }

    public int LegacyProviderId { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateDeactivated { get; set; }

    public string? OtherDescription { get; set; }

    public virtual ICollection<AspNetUserAuthority> AspNetUserAuthorities { get; set; } = new List<AspNetUserAuthority>();

    public virtual OrganizationModel OrganizationModel { get; set; } = null!;

    public virtual ICollection<ProgramTrainingPlan> ProgramTrainingPlans { get; set; } = new List<ProgramTrainingPlan>();
}
