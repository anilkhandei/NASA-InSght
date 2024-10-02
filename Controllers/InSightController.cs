using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> GetAsync()
        {
            var currentDate=DateTime.Now.Date;
            // Check if we've already added data for today
            var didWeAddToday = await _nasaInsigtContext.APICallLogs
                .AnyAsync(l => l.TimeStamp.Date == currentDate);

            if (!didWeAddToday)
            {
                // Fetch data from the InSight API
                var (inSightUrl, response) = await _inSightAPIService.FetchInSightDataAndUrlAsync();

                // Create a new log entry
                var newLogEntry = new APICallLogs
                {
                    APIData = response,
                    APIURL = inSightUrl,
                    TimeStamp = currentDate
                };

                // Add the log entry to the context and save changes
                _nasaInsigtContext.APICallLogs.Add(newLogEntry);
                await _nasaInsigtContext.SaveChangesAsync();
            }

            // Retrieve data from the existing log entry for today
            var existingLogEntry = await _nasaInsigtContext.APICallLogs
                .Where(l => l.TimeStamp.Date == DateTime.Now.Date)
                .Select(l => l.APIData)
                .FirstOrDefaultAsync();

            // Deserialize the response into a JsonObject
            JsonObject? wdm = JsonSerializer.Deserialize<JsonObject>(existingLogEntry??string.Empty);

            // For now, let's assume SOL is a class with the necessary properties
            var sol_keys = JsonSerializer.Deserialize<string[]>(wdm["sol_keys "]) ?? Array.Empty<string>();
            var solList = sol_keys
                .Select(sol_key => JsonSerializer.Deserialize<SOL>(wdm[sol_key]))
                .Where(sol => sol != null)
                .ToList();

            return Ok(solList);
        }


    }
}
