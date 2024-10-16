using Microsoft.EntityFrameworkCore;
using SkillBridgeAPI.Data;
using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Queries
{
    public interface IDeliveryMethodQuery : IQuery
    {
        string? Get(int deliveryMethod);
        string? Get(string deliveryMethod);
        Task<string> Get(IProgram prog);
    }

    public class DeliveryMethodQuery(SkillBridgeDbContext _db) : IDeliveryMethodQuery
    {
        public string? Get(string deliveryMethod)
        {
            return Get(int.Parse(deliveryMethod));
        }

        public string? Get(int deliveryMethod)
        {
            var dms = new Dictionary<int, string>
            {
                { 0, "In-Person" },
                { 1, "In-Person" },
                { 2, "Online" },
                { 3, "Hybrid (In-Person and Online)" }
            };

            dms.TryGetValue(deliveryMethod, out var ret);

            return ret;

        }

        public async Task<string> Get(IProgram prog)
        {
            var pdm = await _db.ProgramDeliveryMethods.AsNoTracking()
                        .Where(x => x.ProgramId == prog.Id).ToArrayAsync();
            var dms = pdm.Select(p => Get(p.DeliveryMethodId)).Where(p => p != null).ToArray();

            return string.Join(" and ", dms);

        }
    }
}
