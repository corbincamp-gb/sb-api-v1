using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Queries
{
    public interface IJobFamilyQuery :IQuery
    {
        IEnumerable<string> Get(IProgram prog);
    }

    public class JobFamilyQuery(SkillBridgeDbContext _db) : IJobFamilyQuery
    {
        /// <summary>
        /// Get the Program Job Families
        /// </summary>
        /// <param name="prog"></param>
        /// <returns>IEnumerable of string</returns>
        public IEnumerable<string> Get(IProgram prog)
        {
            var pjfHash = _db.ProgramJobFamilies.Where(pjf => pjf.ProgramId == prog.Id).ToHashSet();
            return (from pjf in pjfHash
                join jfs in _db.JobFamilies
                    on pjf.JobFamilyId equals jfs.Id
                select jfs.Name).ToArray();



        }
    }
}
