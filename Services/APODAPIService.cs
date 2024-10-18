using NASA_InSight.Models;
using System.Net.Http;
using System.Text.Json;

namespace NASA_InSight.Services
{
    public class APODAPIService : IAPODAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        public APODAPIService(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _config = config;
        }
        public async Task<string> GetAPODUri()
        {
            var _httpClient = _httpClientFactory.CreateClient("NASA");
            var resp=await _httpClient.GetAsync(GetAPODURL());
            string responseStr = string.Empty;
            if (resp != null && resp.IsSuccessStatusCode)
            {
                string insightJson = await resp.Content.ReadAsStringAsync();
                APOD? aPOD = JsonSerializer.Deserialize<APOD>(insightJson)??default;
                responseStr = aPOD!=null ? aPOD.hdurl : string.Empty;
            }
            return responseStr;
        }

        public string GetAPODURL()
        {
            string apiKey = _config.GetSection("NASA:apikey")?.Value ?? "DEMO_KEY";
            string aPodApiEndPoint = _config.GetSection("NASA:APODEndPoint")?.Value ?? string.Empty;
            return string.Format(aPodApiEndPoint,apiKey);
        }
    }

}
