using Azure;
using Microsoft.AspNetCore.Mvc;
using NASA_InSight.Data;
using NASA_InSight.Models;
using NASA_InSight.Services;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace NASA_InSight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InSightController : Controller
    {
        private readonly IInSightAPIService _inSightAPIService;
        private readonly NASAInSightContext _nasaInsigtContext;
        private readonly IConfiguration _config;

        public InSightController(IInSightAPIService inSightAPIService, NASAInSightContext nASAInSightContext, IConfiguration config)
        {
            _inSightAPIService = inSightAPIService;
            _nasaInsigtContext = nASAInSightContext;
            _config = config;
        }
        [HttpGet("GetWeather")]
        public async Task<IActionResult> Get()
        {

            string? response;
            //optimized by AI
            var didWeAddToday = _nasaInsigtContext.APICallLogs.Any(l => l.TimeStamp.Date == DateTime.Now.Date);

            if (!didWeAddToday)
            {
                response = await _inSightAPIService.GetInSightData();
                string inSightUrl = _inSightAPIService.GetInSightURL();
                var newLogEntry = new APICallLogs()
                {
                    APIData = response,
                    APIURL = inSightUrl,
                    TimeStamp = DateTime.Now
                };
                _nasaInsigtContext.APICallLogs.Add(newLogEntry);
                await _nasaInsigtContext.SaveChangesAsync();
            }
            else
            {
                //optimized by AI
                response = _nasaInsigtContext.APICallLogs
                        .Where(l => l.TimeStamp.Date == DateTime.Now.Date)
                        .Select(l => l.APIData)
                        .FirstOrDefault();
            }
            
            JsonObject? wdm = JsonSerializer.Deserialize<JsonObject>(response);

            string[]? sol_keys = JsonSerializer.Deserialize<string[]>(wdm["sol_keys"] ?? default);
            List<SOL?> solList = new();
            if (sol_keys != null && sol_keys.Length > 0)
                solList.AddRange(sol_keys
                    .Select(sol_key => JsonSerializer.Deserialize<SOL>(wdm[sol_key]))
                    .Where(sol => sol != null));

            return Ok(solList);
        }
    }
}
