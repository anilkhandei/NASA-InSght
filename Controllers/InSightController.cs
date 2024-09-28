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
        public InSightController(IInSightAPIService inSightAPIService, NASAInSightContext nASAInSightContext)
        {
            _inSightAPIService = inSightAPIService;   
            _nasaInsigtContext = nASAInSightContext;
        }
        [HttpGet("GetWeather")]
        public async Task<IActionResult> Get()
        {

            string response;
            var didWeAddToday= _nasaInsigtContext.APICallLogs.ToList().Count>0 && _nasaInsigtContext.APICallLogs.Where(l=>l.TimeStamp.Date==DateTime.Now.Date).ToList().Any();
            if (!didWeAddToday)
            {
                response = await _inSightAPIService.GetInSightData();
                
                _nasaInsigtContext.APICallLogs.Add(new APICallLogs()
                {
                    APIData = response,
                    APIURL = "",
                    TimeStamp = DateTime.Now
                });
                await _nasaInsigtContext.SaveChangesAsync();
            }
            else
            {
                response = _nasaInsigtContext.APICallLogs.Where(l => l.TimeStamp.Date == DateTime.Now.Date).First().APIData;
            }

            JsonObject? wdm = JsonSerializer.Deserialize<JsonObject>(response);

            string[]? sol_keys = JsonSerializer.Deserialize<string[]>(wdm["sol_keys"] ?? default);
            List<SOL> solList = new();
            foreach (var sol_key in sol_keys)
            {
                SOL sol = JsonSerializer.Deserialize<SOL>(wdm[sol_key]);
                solList.Add(sol);
            }


            return Ok(solList);
        }
    }
}
