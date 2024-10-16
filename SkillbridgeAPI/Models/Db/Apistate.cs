namespace SkillBridgeAPI.Models.Db;

public partial class Apistate
{
    public int Id { get; set; }

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public string TokenType { get; set; } = null!;

    public int ExpiresIn { get; set; }

    public DateTime ExpirationDate { get; set; }
}
