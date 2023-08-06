using Microsoft.EntityFrameworkCore;

namespace Feedback1API.Models
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext(DbContextOptions Options) : base(Options)
        {

        }
        public DbSet<Feedback> FeedBacks { get; set; }
    }
}