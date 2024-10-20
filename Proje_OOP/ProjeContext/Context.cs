using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;
using System.Net;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-E65OLOAT\\SQLEXPRESS;database=DbNewOopCore;" +
                "integrated security=true;TrustServerCertificate=true;");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
