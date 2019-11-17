using System.Collections.Generic;
using JustInMindServer.Entities;

namespace JustInMindServer.Repositories.Interfaces
{
    public interface IHistoryRepository
    {
        IEnumerable<History> GetAllByTicketId(long ticketId);
    }
}