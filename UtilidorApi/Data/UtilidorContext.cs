using Microsoft.EntityFrameworkCore;
using UtilidorApi.Models;

namespace UtilidorApi.Data
{
    public class UtilidorContext : DbContext
    {
        public UtilidorContext(DbContextOptions<UtilidorContext> context) : base(context) { }

        public DbSet<Utility> Utilities { get; set; }
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
