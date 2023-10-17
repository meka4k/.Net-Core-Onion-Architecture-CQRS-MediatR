using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pencil", Value = 10, Quantity = 5 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 12, Quantity = 7 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper", Value = 15, Quantity = 11 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
