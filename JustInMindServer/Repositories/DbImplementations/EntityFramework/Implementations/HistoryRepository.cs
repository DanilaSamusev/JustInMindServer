using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class HistoryRepository : IHistoryRepository
    {
        public IEnumerable<History> GetAllByTicketId(long ticketId)
        {
            var dbContext = new HistoryContext();
            var histories = dbContext.Histories.Where(history => history.TicketId == ticketId).ToList();
            return histories;
        }
    }
}