using System;
using System.Collections.Generic;
using JustInMindServer.Models;

namespace JustInMindServer.Repositories.Implementations
{
    public class TicketRepository : IRepository<Ticket>
    {
        public string GetAll()
        {
            return "gaga";
        }

        public Ticket GetById(long id)
        {
            throw new System.NotImplementedException();
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