using Microsoft.EntityFrameworkCore;

namespace ImagesAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Images> TourImages { get; set; }
    }
}