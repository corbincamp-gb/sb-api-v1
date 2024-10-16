using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Commands;
using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Queries;

public interface IOrganizationCollectionQuery : IQuery
{
    Task<IEnumerable<IOrganization>> Get();
    Task<IEnumerable<IOrganization>> Get(int page, int size);
    IEnumerable<IOrganization> Get(string filter, bool active, out int totalRecords, int page = 1, int size = 10);
}

public class OrganizationCollectionQuery(SkillBridgeDbContext _db, 
    IDetermineSkipTakeCommand _determineSkipTakeCommand)
    : IOrganizationCollectionQuery
{
    public async Task<IEnumerable<IOrganization>> Get()
    {
        return await _db.Organizations.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<IOrganization>> Get(int page = 1, int size = 10)
    {
        _determineSkipTakeCommand.Execute(page, size, out var pgs);    

        return await _db.Organizations.Skip(pgs.Skip).Take(pgs.Take).AsNoTracking().ToListAsync();

    }
    
    public IEnumerable<IOrganization> Get(string filter, bool active, out int totalRecords, int page = 1, int size = 10)
    {
        _determineSkipTakeCommand.Execute(page, size, out var pgs);
        totalRecords = _db.Organizations.Count(o => o.IsActive.Equals(active));

        return string.IsNullOrEmpty(filter) 
            ? _db.Organizations.Where(o => o.IsActive.Equals(active))
                .OrderBy(o => o.Name)
                .Skip(pgs.Skip)
                .Take(pgs.Take) 
            : _db.Organizations.Where(o => o.IsActive.Equals(active) 
                                           && o.Name.StartsWith(filter))
                .OrderBy(o => o.Name)
                .Skip(pgs.Skip)
                .Take(pgs.Take);

        //        return _db.Organizations.FromSql($"SELECT * FROM Organizations WHERE {filterStr} ORDER BY name OFFSET ({pgs.Skip} - 1) * {pgs.Take} ROWS FETCH NEXT {pgs.Take} ROWS ONLY");

    }
}