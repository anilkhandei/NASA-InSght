using Microsoft.EntityFrameworkCore;

namespace NASA_InSight.Data
{
    public class NASAInSightContext:DbContext
    {
        public NASAInSightContext(DbContextOptions<NASAInSightContext> options)
            :base(options) { }

        public DbSet<APICallLogs> APICallLogs { get; set; }
    }
}
