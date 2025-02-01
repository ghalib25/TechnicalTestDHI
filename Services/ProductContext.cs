using Microsoft.EntityFrameworkCore;
using DataModel;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Services
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Your_MySQL_Connection_String", ServerVersion.AutoDetect("Your_MySQL_Connection_String"));
        }
    }
}