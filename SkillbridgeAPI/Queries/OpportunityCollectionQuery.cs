using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Commands;
using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Queries;

public interface IOpportunityCollectionQuery  : IQuery
{
    Task<IEnumerable<IOpportunity>> Get(int page = 1, int size = 10);
}
public class OpportunityCollectionQuery(SkillBridgeDbContext _db,
    IDetermineSkipTakeCommand _determineSkipTakeCommand)
    : IOpportunityCollectionQuery
{
    public async Task<IEnumerable<IOpportunity>> Get(int page = 1, int size = 10)
    {
        _determineSkipTakeCommand.Execute(page, size, out var pgs);

        return await _db.Opportunities.Skip(pgs.Skip).Take(pgs.Take).ToListAsync();

    }
}