namespace SkillBridgeAPI.Models.Db;

public interface IOpportunity
{
    int Id { get; set; }
    int GroupId { get; set; }
    int OrganizationId { get; set; }
    int ProgramId { get; set; }
    string ProgramName { get; set; }
    string? OpportunityUrl { get; set; }
    DateTime DateProgramInitiated { get; set; }
    DateTime DateCreated { get; set; }
    DateTime DateUpdated { get; set; }
    string EmployerPocName { get; set; }
    string EmployerPocEmail { get; set; }
    string TrainingDuration { get; set; }
    string Service { get; set; }
    string DeliveryMethod { get; set; }
    bool MultipleLocations { get; set; }
    string ProgramType { get; set; }
    string? JobFamilies { get; set; }
    string? ParticipationPopulations { get; set; }
    bool SupportCohorts { get; set; }
    string? EnrollmentDates { get; set; }
    bool Mous { get; set; }
    int NumLocations { get; set; }
    string? Installation { get; set; }
    string? City { get; set; }
    string? State { get; set; }
    string? Zip { get; set; }
    double Lat { get; set; }
    double Long { get; set; }
    bool Nationwide { get; set; }
    bool Online { get; set; }
    string SummaryDescription { get; set; }
    string JobsDescription { get; set; }
    string? LinksToProspectiveJobs { get; set; }
    string? LocationsOfProspectiveJobsByState { get; set; }
    string? Salary { get; set; }
    string? ProspectiveJobLaborDemand { get; set; }
    string? TargetMocs { get; set; }
    string? OtherEligibilityFactors { get; set; }
    string? Cost { get; set; }
    string? Other { get; set; }
    string? Notes { get; set; }
    string? CreatedBy { get; set; }
    string? UpdatedBy { get; set; }
    bool ForSpouses { get; set; }
    string? OrganizationName { get; set; }
    string? MouLink { get; set; }
    DateTime MouExpirationDate { get; set; }
    string? AdminPocFirstName { get; set; }
    string? AdminPocLastName { get; set; }
    string? AdminPocEmail { get; set; }
    int LegacyOpportunityId { get; set; }
    int LegacyProgramId { get; set; }
    int LegacyProviderId { get; set; }
    bool IsActive { get; set; }
    DateTime DateDeactivated { get; set; }
    ICollection<OpportunityGroupModel> OpportunityGroups { get; set; }
}

public partial class OpportunityModel : IOpportunity
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int OrganizationId { get; set; }

    public int ProgramId { get; set; }

    public string ProgramName { get; set; } = null!;

    public string? OpportunityUrl { get; set; }

    public DateTime DateProgramInitiated { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string EmployerPocName { get; set; } = null!;

    public string EmployerPocEmail { get; set; } = null!;

    public string TrainingDuration { get; set; } = null!;

    public string Service { get; set; } = null!;

    public string DeliveryMethod { get; set; } = null!;

    public bool MultipleLocations { get; set; }

    public string ProgramType { get; set; } = null!;

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

    public string SummaryDescription { get; set; } = null!;

    public string JobsDescription { get; set; } = null!;

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

    public string? OrganizationName { get; set; }

    public string? MouLink { get; set; }

    public DateTime MouExpirationDate { get; set; }

    public string? AdminPocFirstName { get; set; }

    public string? AdminPocLastName { get; set; }

    public string? AdminPocEmail { get; set; }

    public int LegacyOpportunityId { get; set; }

    public int LegacyProgramId { get; set; }

    public int LegacyProviderId { get; set; }

    public bool IsActive { get; set; }

    public DateTime DateDeactivated { get; set; }

    public virtual ICollection<OpportunityGroupModel> OpportunityGroups { get; set; } = new List<OpportunityGroupModel>();
}
