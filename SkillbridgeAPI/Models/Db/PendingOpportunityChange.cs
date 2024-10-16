namespace SkillBridgeAPI.Models.Db;

public partial class PendingOpportunityChange
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int OrganizationId { get; set; }

    public int OpportunityId { get; set; }

    public int ProgramId { get; set; }

    public string? ProgramName { get; set; }

    public string? OpportunityUrl { get; set; }

    public DateTime DateProgramInitiated { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? EmployerPocName { get; set; }

    public string? EmployerPocEmail { get; set; }

    public string? TrainingDuration { get; set; }

    public string? Service { get; set; }

    public string? DeliveryMethod { get; set; }

    public bool MultipleLocations { get; set; }

    public string? ProgramType { get; set; }

    public string? JobFamilies { get; set; }

    public string? ParticipationPopulations { get; set; }

    public bool SupportCohorts { get; set; }

    public string? EnrollmentDates { get; set; }

    public bool Mous { get; set; }

    public int NumLocations { get; set; }

    public string? Installation { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public double Lat { get; set; }

    public double Long { get; set; }

    public bool Nationwide { get; set; }

    public bool Online { get; set; }

    public string? SummaryDescription { get; set; }

    public string? JobsDescription { get; set; }

    public string? LinksToProspectiveJobs { get; set; }

    public string? LocationsOfProspectiveJobsByState { get; set; }

    public string? Salary { get; set; }

    public string? ProspectiveJobLaborDemand { get; set; }

    public string? TargetMocs { get; set; }

    public string? OtherEligibilityFactors { get; set; }

    public string? Cost { get; set; }

    public string? Other { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public bool ForSpouses { get; set; }

    public int LegacyOpportunityId { get; set; }

    public int LegacyProgramId { get; set; }

    public int LegacyProviderId { get; set; }

    public int PendingChangeStatus { get; set; }

    public bool IsActive { get; set; }

    public string? LastAdminActionUser { get; set; }

    public DateTime? LastAdminActionTime { get; set; }

    public string? LastAdminActionType { get; set; }

    public string? RejectionReason { get; set; }

    public bool RequiresOsdReview { get; set; }
}
