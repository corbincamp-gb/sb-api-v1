using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Utils;
using Taku.Core;

namespace SkillBridgeAPI.Queries
{
    public interface IHtmlTextQuery : IQuery
    {
        HtmlText Get(string alias);
    }

    public class HtmlTextQuery(SkillBridgeDbContext _db) : IHtmlTextQuery
    {
        public HtmlText Get(string alias)
        {
            var res = _db.HtmlTexts.FirstOrDefault(h => h.Alias == alias);
            Guard.AgainstNull(res, $"The HtmlText alias \"{alias}\" does not ext");
            return res;
        }
    }
}
