using L3Pricing.Entities;
using Microsoft.EntityFrameworkCore;

namespace L3Pricing.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<Service> Services { get; set; }
    }
}
