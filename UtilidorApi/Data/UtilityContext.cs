using Microsoft.EntityFrameworkCore;
using UtilidorApi.Models;

namespace UtilidorApi.Data
{
    public class UtilityContext : DbContext
    {
        public UtilityContext(DbContextOptions<UtilityContext> context) : base(context) { }

        public DbSet<Utility> Utilities { get; set; }
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
