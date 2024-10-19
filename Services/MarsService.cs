
namespace NASA_InSight.Services
{
    public class MarsService : IPlanetService
    {
        public async Task<string> PlanetData()
        {
            await Task.Run(() => {
                Console.WriteLine("Getting data from mars takes time");
                Thread.Sleep(5000);
            });

            return "The red planet called Mars";
        }
    }
}
