namespace NASA_InSight.Services
{
    public interface IPlanetServiceFactory
    {
        IPlanetService GetPlanetService(string planetName);
    }
}
