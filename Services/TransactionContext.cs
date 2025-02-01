using Microsoft.EntityFrameworkCore;
using DataModel;

namespace Services
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Your_PostgreSQL_Connection_String");
        }
    }
}