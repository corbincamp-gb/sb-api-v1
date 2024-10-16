using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Commands;
using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Queries;

public interface IProgramCollectionQuery : IQuery
{
    Task<IEnumerable<IProgram>> Get(int page, int size);
    Task<IEnumerable<IProgram>> Get(IEnumerable<int> ordIds);
}

public class ProgramCollectionQuery(SkillBridgeDbContext _db, 
    IDetermineSkipTakeCommand _determineSkipTakeCommand)
    : IProgramCollectionQuery
{
    public async Task<IEnumerable<IProgram>> Get(int page = 1, int size = 10)
    {
        _determineSkipTakeCommand.Execute(page, size, out var pgs);    

        return await _db.Programs.Skip(pgs.Skip).Take(pgs.Take).AsNoTracking().ToListAsync();

    }

    public async Task<IEnumerable<IProgram>> Get(IEnumerable<int> orgIds)
    {
        return await _db.Programs.Where(p => orgIds.Contains(p.OrganizationId))
            .AsNoTracking().ToListAsync();

    }
}