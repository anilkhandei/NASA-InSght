namespace NASA_InSight.Services
{
    public interface IAPODAPIService
    {
        Task<string> GetAPODUri();
    }
}
