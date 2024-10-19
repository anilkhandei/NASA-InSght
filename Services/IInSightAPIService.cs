namespace NASA_InSight.Services
{
    public interface IInSightAPIService
    {
        Task<string> GetInSightData();
        string GetInSightURL();

        Task<(string, string)> FetchInSightDataAndUrlAsync();
    }
}
