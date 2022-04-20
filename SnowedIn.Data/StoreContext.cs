using SnowedIn.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using SnowedIn.Domain.Orders;

namespace SnowedIn.Data
{
    public class StoreContext : DbContext
    {
        //Need to see if this needs changed
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }
        public DbSet<Item>? Items { get; set; }
        public DbSet<Order>? Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    } 
}
