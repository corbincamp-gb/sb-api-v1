namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramAdditionsParticipationPopulation
{
    public int Id { get; set; }

    public int PendingProgramId { get; set; }

    public int ParticipationPopulationId { get; set; }
}
