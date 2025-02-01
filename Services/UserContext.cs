using Microsoft.EntityFrameworkCore;
using DataModel;

namespace Services
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your_MSSQL_Connection_String");
        }
    }
}