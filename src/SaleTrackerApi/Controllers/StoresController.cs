using Microsoft.AspNetCore.Mvc;
using SaleTrackerApi.Data;
using System.Linq;

namespace SaleTrackerApi.Controllers
{
    [Route("api/[controller]")]
    public class StoresController : Controller
    {
        private readonly SaleTrackerContext _context;

        public StoresController(SaleTrackerContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_context.Sales.ToList());
        }
    }
}