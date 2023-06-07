using Microsoft.EntityFrameworkCore;
using SunshineWax.Models.BookingModels;
using SunshineWax.Models.UserModels;

namespace SunshineWax.Data.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<BookingForm> Forms { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Sunshiners> Sunshiners { get; set; }

    }
}
