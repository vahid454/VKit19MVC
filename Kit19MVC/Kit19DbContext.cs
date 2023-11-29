using Kit19.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Kit19.MyDbContext
{

    public class Kit19DbContext : DbContext
    {
        public Kit19DbContext(DbContextOptions<Kit19DbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public IEnumerable<Product> SearchProducts(
            string productName,
            string size,
            decimal? price,
            DateTime? mfgDate,
            string category,
            string conjunction)
        {
            var parameters = new[]
            {
            new SqlParameter("@ProductName", productName ?? (object)DBNull.Value),
            new SqlParameter("@Size", size ?? (object)DBNull.Value),
            new SqlParameter("@Price", price ?? (object)DBNull.Value),
            new SqlParameter("@MfgDate", mfgDate ?? (object)DBNull.Value),
            new SqlParameter("@Category", category ?? (object)DBNull.Value),
            new SqlParameter("@Conjunction", conjunction ?? (object)DBNull.Value)
        };

            return Product.FromSqlRaw("EXEC SearchProducts @ProductName, @Size, @Price, @MfgDate, @Category, @Conjunction", parameters).ToList();
        }

    }
    
}
