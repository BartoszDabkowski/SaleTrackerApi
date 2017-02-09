using Microsoft.AspNetCore.Mvc;

namespace SaleTrackerApi.Controllers
{
    [Route("api/[controller]")]
    public class StoresController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new {Test = "Test"});
        }
    }
}