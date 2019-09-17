using JustInMindServer.Models;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.Contexts
{
    public class UserContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=just_in_mind_db;password=root;");
            }
        }
        public virtual DbSet<User> Users { get; set; }
    }
}