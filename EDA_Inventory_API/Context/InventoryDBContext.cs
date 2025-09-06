using EDA_Inventory_API.Data;
using Microsoft.EntityFrameworkCore;

namespace EDA_Inventory_API.Context
{
    public class InventoryDBContext: DbContext
    {
        public InventoryDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { 

        }


        public DbSet<Product> Product { get; set; }
    }
}
