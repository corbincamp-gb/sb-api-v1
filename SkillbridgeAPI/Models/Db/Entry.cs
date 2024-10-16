namespace SkillBridgeAPI.Models.Db;

public partial class Entry
{
    public int Id { get; set; }

    public int EntryStatusId { get; set; }

    public string ZohoTicketId { get; set; } = null!;

    public string OrganizationName { get; set; } = null!;

    public string Ein { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string City { get; set; } = null!;

    public int StateId { get; set; }

    public string ZipCode { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Url { get; set; } = null!;

    public byte NumberOfPrograms { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime AddedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public string PocFirstName { get; set; } = null!;

    public string PocLastName { get; set; } = null!;

    public string PocTitle { get; set; } = null!;

    public string PocPhoneNumber { get; set; } = null!;

    public string PocEmail { get; set; } = null!;

    public string? InternalNotes { get; set; }

    public string? RejectionReason { get; set; }

    public string? ExternalNotes { get; set; }

    public bool ReviewedByAnalyst { get; set; }

    public bool ReviewedByOsd { get; set; }

    public virtual ICollection<EntryStatusTracking> EntryStatusTrackings { get; set; } = new List<EntryStatusTracking>();

    public virtual ICollection<FileModel> Files { get; set; } = new List<FileModel>();

    public virtual ICollection<Form> Forms { get; set; } = new List<Form>();

    public virtual State State { get; set; } = null!;
}
