using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Utils;
using Taku.Core;


namespace SkillBridgeAPI.Queries
{
    public interface IMouQuery : IQuery
    {
        IMou Get(int id);
    }

    public class MouQuery(SkillBridgeDbContext _db) : IMouQuery
    {
        public IMou Get(int id)
        {
            var ret = _db.Mous.FirstOrDefault(m => m.Id.Equals(id));

            Guard.AgainstNull(ret, "Mou missing or not found");

            return ret;
        }
    }
}
