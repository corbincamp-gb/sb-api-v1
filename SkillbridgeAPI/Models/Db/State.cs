namespace SkillBridgeAPI.Models.Db;

public partial class State
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Label { get; set; }

    public virtual ICollection<Entry> Entries { get; set; } = new List<Entry>();
}
