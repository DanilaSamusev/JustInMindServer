using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.Implementations
{
    public class TicketRepository : IRepository<Ticket>
    {
        public IEnumerable<Ticket> GetAll()
        {
            using (TicketContext dbContext = new TicketContext())
            {
                var tickets = dbContext.Tickets.ToList();

                return tickets;
            }
        }

        public Ticket GetById(long id)
        {
            using (TicketContext dbContext = new TicketContext())
            {

                var ticket = dbContext.Tickets.FirstOrDefault(t => t.Id == id);
                
                return ticket;
            }
        }

        public void Add(Ticket obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}