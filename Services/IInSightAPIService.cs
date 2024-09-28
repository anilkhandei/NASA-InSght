namespace NASA_InSight.Services
{
    public interface IInSightAPIService
    {
        Task<string> GetInSightData();
    }
}
