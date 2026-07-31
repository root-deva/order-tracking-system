using Microsoft.EntityFrameworkCore;
using Order_Tracking_System.Web.Models;


namespace Order_Tracking_System.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Order> Orders { get; set; } = null!;
    }
}
