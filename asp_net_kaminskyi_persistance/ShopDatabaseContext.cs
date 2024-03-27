using asp_net_project_kaminskyi_item_23_1_web.Domain;
using Microsoft.EntityFrameworkCore;

namespace asp_net_kaminskyi_persistance
{
    public class ShopDatabaseContext : DbContext
    {
        public ShopDatabaseContext(DbContextOptions<ShopDatabaseContext> options) : base(options)
        { 
            this.Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
