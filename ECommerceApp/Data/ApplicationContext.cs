using ECommerceApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        
        // The connection string for SQL Server database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // You can replace the connection string below with your actual connection string
            var connectionString = "Server=localhost;Database=EASV-DB-Compulsary-Assignment-1;User Id=sa;Password=YourStrong!Passw0rd;Encrypt=false;";
            options.UseSqlServer(connectionString);
        }
    }
}
