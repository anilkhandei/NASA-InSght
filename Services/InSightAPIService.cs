namespace NASA_InSight.Services
{
    public class InSightAPIService : IInSightAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        public InSightAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClientFactory.CreateClient("InSight");
        }
        public async Task<string> GetInSightData()
        {
            var resp = await _httpClient.GetAsync("insight_weather/?api_key=DEMO_KEY&feedtype=json&ver=1.0");
            string responseStr = string.Empty;
            if (resp != null && resp.IsSuccessStatusCode)
            {
                string insightJson = await resp.Content.ReadAsStringAsync();
                responseStr= insightJson;
            }
            return responseStr;
        }
    }
}
