using HomeNet.API.Devices;
using Microsoft.EntityFrameworkCore;

namespace HomeNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Device> Device { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
