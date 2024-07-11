using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace MmaccessoriesAPI.Models
{

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collection>().HasData(
                new Collection { Id = 1, Name = "Necklace" },
                new Collection { Id = 2, Name = "Earrings" },
                new Collection { Id = 3, Name = "Rings" },
                new Collection { Id = 4, Name = "Bags" },
                new Collection { Id = 5, Name = "Shoes" });

            modelBuilder.Entity<Kinds>().HasData(
                new Kinds { Id = 1, CollectionId = 1, Name = "Chain ", Price = 8000, IsAvailable = true },
                new Kinds { Id = 2, CollectionId = 1, Name = "Choker", Price = 9500, IsAvailable = true },
                new Kinds { Id = 3, CollectionId = 1, Name = "Pendant", Price = 6000, IsAvailable = true },
                new Kinds { Id = 4, CollectionId = 1, Name = "Torque", Price = 10000, IsAvailable = true },
                new Kinds { Id = 5, CollectionId = 1, Name = "Locket", Price = 17000, IsAvailable = true },
                new Kinds { Id = 6, CollectionId = 2, Name = "Stud", Price = 3500, IsAvailable = true },
                new Kinds { Id = 7, CollectionId = 2, Name = "Hoop", Price = 4500, IsAvailable = true },
                new Kinds { Id = 8, CollectionId = 2, Name = "Dangle", Price = 3000, IsAvailable = true },
                new Kinds { Id = 9, CollectionId = 2, Name = "Teardrop", Price = 6000, IsAvailable = true },
                new Kinds { Id = 10, CollectionId = 2, Name = "Jacket", Price = 9000, IsAvailable = true },
                new Kinds { Id = 11, CollectionId = 3, Name = "Pear Rings", Price = 20000, IsAvailable = false },
                new Kinds { Id = 12, CollectionId = 3, Name = "Adjustable Rings", Price = 15000, IsAvailable = true },
                new Kinds { Id = 13, CollectionId = 3, Name = "Charm Rings", Price = 10000, IsAvailable = true },
                new Kinds { Id = 14, CollectionId = 3, Name = "Engagement Rings", Price = 50000, IsAvailable = true },
                new Kinds { Id = 15, CollectionId = 3, Name = "Solitaire Rings", Price = 30000, IsAvailable = true },
                new Kinds { Id = 16, CollectionId = 4, Name = "Shoulder Bags", Price = 19500, IsAvailable = true },
                new Kinds { Id = 17, CollectionId = 4, Name = "Tote Bags", Price = 4500, IsAvailable = true },
                new Kinds { Id = 18, CollectionId = 4, Name = "Clutch Bags", Price = 20000, IsAvailable = true },
                new Kinds { Id = 19, CollectionId = 4, Name = "Crossbody Bags", Price = 35000, IsAvailable = true },
                new Kinds { Id = 20, CollectionId = 4, Name = "Backpacks", Price = 24000, IsAvailable = true },
                new Kinds { Id = 21, CollectionId = 5, Name = "Flats", Price = 12000, IsAvailable = true },
                new Kinds { Id = 22, CollectionId = 5, Name = "Sandal", Price = 9000, IsAvailable = true },
                new Kinds { Id = 23, CollectionId = 5, Name = "Sneakers", Price = 15500, IsAvailable = true },
                new Kinds { Id = 24, CollectionId = 5, Name = "Heels", Price = 28000, IsAvailable = true },
                new Kinds { Id = 25, CollectionId = 5, Name = "Boot", Price = 30000, IsAvailable = true }); 

        }
    }
}
