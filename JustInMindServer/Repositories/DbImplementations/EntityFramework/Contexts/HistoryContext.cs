using JustInMindServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts
{
    public class HistoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(
                    "server=localhost;user=root;database=just_in_mind_db;password=root;"
                );
            }
        }
        
        public DbSet<History> Histories { get; set; }
    }
}