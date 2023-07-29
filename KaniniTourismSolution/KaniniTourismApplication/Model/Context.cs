using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace KaniniTourismApplication.Model
{
   
    
        public class Context : DbContext
        {
            static string pass = "admin";
            static HMACSHA512 hmac = new HMACSHA512();
            Byte[] PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(pass));
            Byte[] PasswordKey = hmac.Key;
            public Context(DbContextOptions options) : base(options)
            {


            }
            public DbSet<Traveller> Travellers { get; set; }
            public DbSet<TravelAgent> TravelAgents { get; set; }
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        UserId = 1,
                        EmailId = "admin@gmail.com",
                        PasswordHash = PasswordHash,
                        PasswordKey = PasswordKey,
                        Role = "Admin"
                    });
            }
        }
}


