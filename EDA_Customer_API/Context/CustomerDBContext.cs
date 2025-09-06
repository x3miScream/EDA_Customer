using EDA_Customer_API.Data;
using Microsoft.EntityFrameworkCore;

namespace EDA_Customer_API.Context
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
