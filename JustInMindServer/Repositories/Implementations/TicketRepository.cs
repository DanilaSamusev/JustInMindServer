using System;
using System.Collections.Generic;
using JustInMindServer.Models;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.Implementations
{
    public class TicketRepository : ITicketRepository
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