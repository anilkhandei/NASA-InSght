using Microsoft.AspNetCore.Mvc;
using NASA_InSight.Data;
using NASA_InSight.Services;

namespace NASA_InSight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APODController : Controller
    {
        private readonly IAPODAPIService _aPODAPISvc;
        private readonly NASAInSightContext _nasaInsigtContext;
        private readonly IConfiguration _config;
        public APODController(IAPODAPIService aPODAPISvc, NASAInSightContext nASAInSightContext, IConfiguration config)
        {
            _aPODAPISvc = aPODAPISvc;
            _nasaInsigtContext = nASAInSightContext;
            _config = config;
        }

        [HttpGet("GetURL")]
        public async Task<IActionResult> GetURL()
        {
            return Ok(await _aPODAPISvc.GetAPODUri());
        }
    }
}
