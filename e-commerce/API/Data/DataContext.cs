using Microsoft.EntityFrameworkCore;
using API.Entity;                // Product burada

namespace API.Data               // BLOK şeklinde namespace (küme parantezleriyle)
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Apple Watch Series 7",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "1.jpg",
                        Price = 10000,
                        IsActive = true,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Apple Watch Series 8",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "2.jpg",
                        Price = 20000,
                        IsActive = true,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Apple Watch Series 9",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "3.jpg",
                        Price = 30000,
                        IsActive = false,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Apple Watch Series 10",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "4.jpg",
                        Price = 40000,
                        IsActive = true,
                        Stock = 100
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Apple Watch Series 11",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "5.jpg",
                        Price = 50000,
                        IsActive = true,
                        Stock = 100
                    }
                    ,
                    new Product
                    {
                        Id = 6,
                        Name = "Apple Watch Series 12",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "6.jpg",
                        Price = 60000,
                        IsActive = true,
                        Stock = 100
                    }
                                        ,
                    new Product
                    {
                        Id = 7,
                        Name = "Apple Watch Series 13",
                        Description = "Akıllı Saat açıklaması",
                        ImageUrl = "7.jpg",
                        Price = 70000,
                        IsActive = true,
                        Stock = 100
                    }
                }
            );
        }
    }
}
