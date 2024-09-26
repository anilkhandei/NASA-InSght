using Microsoft.AspNetCore.Mvc;

namespace NASA_InSight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InSightController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        public InSightController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient=httpClientFactory.CreateClient("InSight");
        }
        [HttpGet("GetWeather")]
        public async Task Get()
        {
            var resp=await _httpClient.GetAsync("insight_weather/?api_key=DEMO_KEY&feedtype=json&ver=1.0");
            if (resp != null && resp.IsSuccessStatusCode)
            {
                string insightJson= await resp.Content.ReadAsStringAsync();
            }
        }
    }
}
