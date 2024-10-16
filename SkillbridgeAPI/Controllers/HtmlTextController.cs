using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using SkillBridgeAPI.Models.Db;
using SkillBridgeAPI.Queries;

namespace SkillBridgeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HtmlTextController(IHtmlTextQuery _htmlTextQuery) : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<HtmlText> Get(string alias)
        {
            return _htmlTextQuery.Get(alias);
        }
    }
}
