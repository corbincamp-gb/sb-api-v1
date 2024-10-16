using SkillBridgeAPI.Models.Db;
using Taku.Core;

namespace SkillBridgeAPI.Mappings
{
    public interface IOpportunityCollectionMapping : IMapping
    {
        Task<IEnumerable<IOpportunity>> Map();
    }

    public class OpportunityCollectionMapping : IOpportunityCollectionMapping
    {
        public async Task<IEnumerable<IOpportunity>> Map()
        {
            var fData = new Dictionary<string, string>
            {
                { "College Station", "TX" },
                { "Austin", "TX" },
                { "Norman", "OK" },
                { "Fayetteville", "AR" },
                { "Colombia", "MO" },
                { "Lexington", "KY" },
                { "Knoxville", "TN" },
                { "Oxford", "MS" },
                { "Starkville", "MS" },
                { "Baton Rouge", "LA" },
                { "Tuscaloosa", "AL" },
                { "Auburn", "AL" },
                { "Athens", "GA" },
                { "Gainesville", "FL" },
                { "Columbia", "SC" },
                { "Nashville", "TN" }

            };

            return null;

        }
    }
}
