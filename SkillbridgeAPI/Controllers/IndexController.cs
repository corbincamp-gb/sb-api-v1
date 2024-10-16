using Microsoft.AspNetCore.Mvc;

namespace SkillBridgeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Content("Index Get");
        }
    }
}
