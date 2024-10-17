using Microsoft.Extensions.Caching.Memory;
using SkillBridgeAPI.Commands;
using SkillBridgeAPI.Mappings;
using SkillBridgeAPI.Queries;
using System.Drawing;
using SkillBridgeAPI.Caching;
using Taku.Core;
using Taku.Core.Models;

namespace SkillBridgeAPI.Broker
{
    public interface IOrganizationDataBroker : IBroker
    {
        Task<ProgramOrganizationListModel> Render(string searchValue, int? draw = null, int? page = null, int? size = null);
    }

    public class OrganizationDataBroker(
        ICacheQuery _cacheQuery,
        ICacheItemCommand _cacheItemCommand,
        IOrganizationCollectionQuery _organizationCollectionQuery,
        IProgramCollectionQuery _programCollectionQuery,
        IDetermineProgramDurationCommand _determineProgramDurationCommand,
        IDeliveryMethodQuery _deliveryMethodQuery,
        IJobFamilyQuery _jobFamilyQuery,
        IProgramOrganizationListMapping _programOrganizationListMapping,
        IProgramOrganizationListItemMapping _programOrganizationListItemMapping)
    : IOrganizationDataBroker
    {
       
        public async Task<ProgramOrganizationListModel> Render(string searchValue, int? draw, int? page = 0, int? size = null)
        {
            if (_cacheQuery.Get<ProgramOrganizationListModel>(CacheKeys.ProgramOrgs, out var cacheResult))
            {

                return _programOrganizationListMapping.Map(draw.Value, size.Value, cacheResult);
            }

            var ret = _programOrganizationListMapping.Map();
            var data = ret.Data.ToList();

            var orgs = _organizationCollectionQuery.Get(searchValue, true, out var rowCount, page: page, size: size).ToHashSet();
            ret.RecordsTotal = rowCount;
            ret.RecordsFiltered = rowCount;
            ret.Draw = page.HasValue 
                ? (page.Value == 0 ? 1 : page.Value) 
                : 0;
            
            var progs = _programCollectionQuery.Get(orgs.Select(o => o.Id)).Result.ToHashSet();
            
            foreach (var org in orgs)
            {
                var subProgs = progs.Where(x => x.OrganizationId == org.Id && x.IsActive).ToArray();

                var devMethods = new List<string?>();
                var oppTypes = new List<string>();
                var durations = new List<int>();
                var jobFamilies = new List<string?>();
                var states = Enumerable.Empty<string>();

                var newDeliveryMethod = string.Empty;
                var newCohorts = false;
                var newJobFamilies = Enumerable.Empty<string>();
                
                var nationWide = false;
                var online = false;
                var locationDetailsAvailable = false;

                var progName = string.Empty;

                
                foreach (var prog in subProgs)
                {
                    if (!devMethods.Contains(prog.DeliveryMethod) && !string.IsNullOrEmpty(prog.DeliveryMethod))
                    {
                        devMethods.Add(prog.DeliveryMethod);
                    }

                    if (!oppTypes.Contains(prog.OpportunityType))
                    {
                        oppTypes.Add(prog.OpportunityType);
                    }

                    if (!durations.Contains(prog.ProgramDuration))
                    {
                        durations.Add(prog.ProgramDuration);
                    }

                    if (!jobFamilies.Contains(prog.JobFamily))
                    {
                        jobFamilies.Add(prog.JobFamily);
                    }

                    states = prog.StatesOfProgramDelivery?.Split(',').Distinct().Select(s => s.Trim()).ToArray();

                    newDeliveryMethod = await _deliveryMethodQuery.Get(prog);
                    newCohorts = prog.SupportCohorts;
                    newJobFamilies = _jobFamilyQuery.Get(prog);
                    nationWide = prog.Nationwide;
                    online = prog.Online;
                    locationDetailsAvailable = prog.LocationDetailsAvailable;

                    progName = prog.ProgramName;
                }

                _determineProgramDurationCommand.Execute(durations, ",", out var newProgramDuration);

                data.Add(_programOrganizationListItemMapping.Map(progName,
                    org,
                    oppTypes,
                    newDeliveryMethod,
                    newProgramDuration,
                    states,
                    nationWide,
                    online,
                    newCohorts,
                    locationDetailsAvailable,
                    newJobFamilies,
                    DateTime.Parse("6/30/2025")));
            }

            ret.Data = data;

            _cacheItemCommand.Execute(CacheKeys.ProgramOrgs, ret, true, 240, 30, 2048);
            
            return ret;
        }
    }
}