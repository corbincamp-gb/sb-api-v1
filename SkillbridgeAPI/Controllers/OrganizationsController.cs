using Microsoft.AspNetCore.Mvc;
using SkillBridgeAPI.Broker;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Queries;
using Taku.Core.Models;

namespace SkillBridgeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrganizationsController(
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
        public async Task<ProgramOrganizationListModel> GetOrganizationPrograms(string filter = "", int page = 0, int size = 10)
        {
            return await _organzationDataBroker.Render(filter,page, size);
        }
    }
}
