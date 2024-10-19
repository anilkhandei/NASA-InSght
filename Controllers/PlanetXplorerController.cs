using Microsoft.AspNetCore.Mvc;
using NASA_InSight.Services;

namespace NASA_InSight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetXplorerController : Controller
    {
        private readonly IPlanetServiceFactory _serviceFactory;
        public PlanetXplorerController(IPlanetServiceFactory planetServiceFactory)
        {
                _serviceFactory= planetServiceFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string planet)
        {
            IPlanetService planetService=_serviceFactory.GetPlanetService(planet);
            string planetInfo =await planetService.PlanetData();
            return Ok(planetInfo);
        }

    }
}
