using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Data.EntityConfiguration;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase.Data
{
    internal class SalesContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog = SalesDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\";Command Timeout=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Sales");

            modelBuilder.ApplyConfiguration(new ProductEntityConfig());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfig());
            modelBuilder.ApplyConfiguration(new SaleEntityConfig());
            modelBuilder.ApplyConfiguration(new StoreEntityConfig());


        }

    }
}
