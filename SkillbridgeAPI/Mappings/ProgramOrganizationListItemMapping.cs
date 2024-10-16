using SkillBridgeAPI.Models;
using SkillBridgeAPI.Models.Db;
using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Mappings
{
    public interface IProgramOrganizationListItemMapping : IMapping
    {
        ProgramOrganizationListItemModel Map(string program,
            IOrganization org,
            IEnumerable<string> oppTypes,
            string deliveryMethod,
            string progDuration,
            IEnumerable<string> states,
            bool nationWide,
            bool online,
            bool cohorts,
            bool locationDetailsAvailable,
            IEnumerable<string> jobFamilies,
            DateTime mouExtDate);
    }

    public class ProgramOrganizationListItemMapping : IProgramOrganizationListItemMapping
    {
        public ProgramOrganizationListItemModel Map(string program, 
            IOrganization org,
            IEnumerable<string> oppTypes, 
            string deliveryMethod,
            string progDuration, 
            IEnumerable<string> states, 
            bool nationWide, 
            bool online, 
            bool cohorts,
            bool locationDetailsAvailable,
            IEnumerable<string> jobFamilies,
            DateTime mouExtDate)
        {
            return new ProgramOrganizationListItemModel()
            {
                Program = program,
                Url = string.IsNullOrEmpty(org.OrganizationUrl) ? string.Empty : org.OrganizationUrl,
                OpportunityType = string.Join(", ", oppTypes.ToArray()),
                DeliveryMethod = deliveryMethod,
                ProgramDuration = progDuration,
                States = states.Count() == 1 && states.First().Length == 0 ? [] : states.OrderBy(s => s).ToArray(),
                NationWide = nationWide,
                Online = online,
                Cohorts = cohorts,
                JobFamily = string.Join(", ",jobFamilies),
                LocationDetailsAvailable = locationDetailsAvailable,
                MouExtDate = mouExtDate
            };
        }
    }
}
