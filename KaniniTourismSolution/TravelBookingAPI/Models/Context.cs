using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TravelBookingAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<OTravellers> Tour_Travellers { get; set; }
    }
}
