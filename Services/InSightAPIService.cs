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
            _httpClient = httpClientFactory.CreateClient("NASA");
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
            string inSightEndPoint = _config.GetSection("NASA:InSightEndpoint")?.Value ?? string.Empty;
            return string.Format(inSightEndPoint, apiKey);
        }
        async public Task<(string,string)> FetchInSightDataAndUrlAsync()
        {
            return (GetInSightURL(), await GetInSightData());
        }

    }
}
