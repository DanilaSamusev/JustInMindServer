using System.Collections.Generic;
using System.Linq;
using JustInMindServer.Entities;
using JustInMindServer.Repositories.DbImplementations.EntityFramework.Contexts;
using JustInMindServer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JustInMindServer.Repositories.DbImplementations.EntityFramework.Implementations
{
    public class HistoryRepository : IHistoryRepository
    {
        public IEnumerable<History> GetAllByTicketId(long ticketId)
        {
            var dbContext = new HistoryContext();
            var histories = dbContext.Histories.FromSql("Select date, action, description, u.firstName as userName" +
                                                        " from histories h" +
                                                        " left join users u on u.id = userId" +
                                                        $" where h.ticketId = {ticketId}").ToList();
            return histories;
        }
    }
}