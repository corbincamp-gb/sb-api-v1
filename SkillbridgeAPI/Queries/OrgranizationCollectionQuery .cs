using System.Reflection.Metadata.Ecma335;
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
    IEnumerable<IOrganization> Get(string filter, bool active, out int totalRecords, int? draw = 0, int? page = 0, int? size = null);
}

public class OrganizationCollectionQuery(SkillBridgeDbContext _db, 
    IDetermineSkipTakeCommand _determineSkipTakeCommand)
    : IOrganizationCollectionQuery
{
    public async Task<IEnumerable<IOrganization>> Get()
    {
        return await _db.Organizations.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<IOrganization>> Get(int page = 0, int size = 10)
    {
        _determineSkipTakeCommand.Execute(page, size, out var pgs);    

        return await _db.Organizations.Skip(pgs.Skip).Take(pgs.Take).AsNoTracking().ToListAsync();

    }

    //public IEnumerable<IOrganization> Get(string filter, bool active, out int totalRecords, int? page = 0, int? size = null)
    public IEnumerable<IOrganization> Get(string searchValue, bool active, out int recordsTotal, int? draw, int? start, int? length)
    {
        //_determineSkipTakeCommand.Execute(page, size, out var pgs);
        //totalRecords = _db.Organizations.Count(o => o.IsActive.Equals(active));

        //var data = string.IsNullOrEmpty(filter) 
        //    ? _db.Organizations.Where(o => o.IsActive.Equals(active))
        //        .OrderBy(o => o.Name)
        //    : _db.Organizations.Where(o => o.IsActive.Equals(active) 
        //                                   && o.Name.StartsWith(filter))
        //        .OrderBy(o => o.Name)

        //        return _db.Organizations.FromSql($"SELECT * FROM Organizations WHERE {filterStr} ORDER BY name OFFSET ({pgs.Skip} - 1) * {pgs.Take} ROWS FETCH NEXT {pgs.Take} ROWS ONLY");
        //var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
        //var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
        //var searchValue = Request.Form["search[value]"].FirstOrDefault();
        var pageSize = length != null ? Convert.ToInt32(length) : 0;
        var skip = start != null ? Convert.ToInt32(start) : 0;
        var orgData = (from tempOrg in _db.Organizations select tempOrg);
        //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
        //{
        //    customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
        //}
        if (!string.IsNullOrEmpty(searchValue))
        {
            orgData = orgData.Where(o => o.Name.Contains(searchValue));
        }
        recordsTotal = orgData.Count();
        var data = orgData.Skip(skip).Take(pageSize).ToList();
        return data;
        //var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
        //return jsonData;
    }
}