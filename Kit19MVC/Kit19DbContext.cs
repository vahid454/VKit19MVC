using Kit19.Model;
using Microsoft.EntityFrameworkCore;

namespace Kit19.MyDbContext
{
  
        public class Kit19DbContext : DbContext
        {
            public Kit19DbContext(DbContextOptions<Kit19DbContext> options) : base(options)
            {
            }

            public DbSet<Product> Product { get; set; }
        }
    
}
