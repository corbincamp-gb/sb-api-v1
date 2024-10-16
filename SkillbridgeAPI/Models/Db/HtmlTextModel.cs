using System.ComponentModel.DataAnnotations;

namespace SkillBridgeAPI.Models.Db;


public partial class HtmlText
{
    [Key]

    public int Id { get; set; }

    public string Alias { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Html { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }
}
