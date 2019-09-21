using System.Collections.Generic;
using JustInMindServer.Entities.DTO;
using JustInMindServer.Models;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        IEnumerable<TicketDTO> GetAllDto();
        Ticket GetById(long id);
        void Add(Ticket ticket);
        void Delete(long id);
    }
}