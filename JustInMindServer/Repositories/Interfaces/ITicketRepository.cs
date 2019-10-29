using System.Collections.Generic;
using JustInMindServer.Entities;
using JustInMindServer.Models;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket GetById(long id);
        long Add(Ticket ticket);
        void Delete(long id);
    }
}