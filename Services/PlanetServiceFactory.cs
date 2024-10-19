
namespace NASA_InSight.Services
{
    public class PlanetServiceFactory : IPlanetServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public PlanetServiceFactory(IServiceProvider serviceProvider)
        {
                _serviceProvider = serviceProvider;
        }
        public IPlanetService GetPlanetService(string planetName)
        {
            IPlanetService? service= planetName switch
            {
                "mars" => _serviceProvider.GetService<MarsService>(),
                "earth" => _serviceProvider.GetService<EarthService>(),
                _ => null
            };
            if (service == null)
            {
                throw new KeyNotFoundException($"Service with key {planetName} not registered.");
            }
            return service;
        }
    }
}
