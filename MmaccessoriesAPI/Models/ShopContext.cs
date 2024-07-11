using Microsoft.EntityFrameworkCore;

namespace MmaccessoriesAPI.Models
    {
        public class ShopContext : DbContext
        {
            public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Collection>()
                    .HasMany(c => c.Kinds)
                    .WithOne(a => a.Collection)
                    .HasForeignKey(a => a.CollectionId);

                modelBuilder.Seed();
            }

            public DbSet<Kinds> Kinds { get; set; }
            public DbSet<Collection> Categories { get; set; }
        }
    }



