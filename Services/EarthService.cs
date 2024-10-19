
namespace NASA_InSight.Services
{
    public class EarthService : IPlanetService
    {
        public async Task<string> PlanetData()
        {
            await Task.Run(() => {
                Console.WriteLine("Getting data from earth doesn't takes time");
                Thread.Sleep(500);
            });

            return "The blue planet called our home, Earth";
        }
    }
}
