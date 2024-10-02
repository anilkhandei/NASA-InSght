namespace NASA_InSight.Services
{
    public class InSightAPIService : IInSightAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        public InSightAPIService(IHttpClientFactory httpClientFactory,IConfiguration config)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClientFactory.CreateClient("InSight");
            _config = config;
        }
        public async Task<string> GetInSightData()
        {
            var resp = await _httpClient.GetAsync(GetInSightURL());
            string responseStr = string.Empty;
            if (resp != null && resp.IsSuccessStatusCode)
            {
                string insightJson = await resp.Content.ReadAsStringAsync();
                responseStr= insightJson;
            }
            return responseStr;
        }
        public string GetInSightURL()
        {
            string apiKey=_config.GetSection("NASA:apikey")?.Value ?? "DEMO_KEY";
            return $"insight_weather/?api_key={apiKey}&feedtype=json&ver=1.0";
        }
        async public Task<(string,string)> FetchInSightDataAndUrlAsync()
        {
            return (GetInSightURL(), await GetInSightData());
        }

    }
}
