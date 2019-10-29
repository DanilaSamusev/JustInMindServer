using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;


namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class TicketRepository : ITicketRepository
    {
        public IEnumerable<Ticket> GetAll()
        {
            return null;
        }

        public Ticket GetById(long id)
        {
            using (var dbContext = new TicketContext())
            {
                var ticket = dbContext.Tickets.FirstOrDefault(t => t.Id == id);

                return ticket;
            }
        }

        public long Add(Ticket ticket)
        {
            var dbContext = new TicketContext();

            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();

            return ticket.Id;
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}