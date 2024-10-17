using LazyCache;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SkillBridgeAPI.Broker;
using SkillBridgeAPI.Caching;
using SkillBridgeAPI.Commands;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Queries;
using Taku.Core.Models;

namespace SkillBridgeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganizationsController(ICacheProvider _cacheProvider,
        IOrganizationCollectionQuery _organizationCollectionQuery,
        IOrganizationDataBroker _organzationDataBroker) : ControllerBase
    {
        /// <summary>
        /// Gets a list of Organizations
        /// </summary>
        /// <param name="page">The page requested</param>
        /// <param name="size">The size page to return</param>
        /// <returns></returns>
        [Route("/Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IEnumerable<IOrganization>> GetOrganizations(int page = 0, int size = 10)
        {
            return await _organizationCollectionQuery.Get(page, size);
        }

        [Route("/GetOrgPrograms")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ProgramOrganizationListModel> GetOrganizationPrograms(string searchValue = "", int? draw = null, int? page = null, int? size = null)
        {
            return await _organzationDataBroker.Render(searchValue, draw, page, size);
        }
    }
}
