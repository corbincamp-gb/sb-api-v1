namespace SkillBridgeAPI.Models.Db;

public partial class PendingProgramParticipationPopulation
{
    public int Id { get; set; }

    public int ProgramId { get; set; }

    public int PendingProgramId { get; set; }

    public int ParticipationPopulationId { get; set; }
}
