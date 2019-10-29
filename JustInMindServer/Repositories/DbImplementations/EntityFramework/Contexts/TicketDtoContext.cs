using JustInMindServer.Dto;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts
{
    public class TicketDtoContext : DbContext
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

        public DbSet<TicketDtoToOverview> TicketsDtoToOverview { get; set; }
        public DbSet<TicketDtoToDisplay> TicketsDtoToDisplay { get; set; }
    }
}