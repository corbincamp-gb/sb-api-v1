using Microsoft.AspNetCore.Mvc;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Queries;
// ReSharper disable InconsistentNaming

namespace SkillBridgeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OpportunitiesController(
        ILogger<OpportunitiesController> _logger, 
        IOpportunityCollectionQuery _opportunityCollectionQuery) 
        : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<IOpportunity>> Get()
        {
            _logger.LogInformation("Get Called");
            return await _opportunityCollectionQuery.Get();
        }
    }
}
