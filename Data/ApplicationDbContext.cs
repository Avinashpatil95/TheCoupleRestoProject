using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Models;

namespace RestaurantWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}