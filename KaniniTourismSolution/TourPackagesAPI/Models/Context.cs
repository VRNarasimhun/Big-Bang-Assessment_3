using Microsoft.EntityFrameworkCore;

namespace TourPackagesAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Packages> Tourpackages { get; set; }
        public DbSet<Itenary> Itenaries { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
    }
}
