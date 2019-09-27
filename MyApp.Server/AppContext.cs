using Microsoft.EntityFrameworkCore;
using MyApp.Core.Models;


namespace MyApp.Server
{
    public class AppContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
